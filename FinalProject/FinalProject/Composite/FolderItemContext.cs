using FinalProject.Command;
using FinalProject.Memento;
using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.Composite;

public class FolderItemContext
{
    public string Name { get; set; }
    public double Size { get; set; }

    private FolderItemState folderItemState;

    public Stack<FolderItemMemento> History { get; set; }

    public FolderItemContext(string name, double size)
    {
        Name = name;
        Size = size;
        folderItemState=new Modified(this);
        History = new Stack<FolderItemMemento>();
    }
    public void ChangeState(FolderItemState state)
    {
        folderItemState = state;
    }
    public void SaveAction()
    {
        FolderItemMemento m = new FolderItemMemento(this);
        History.Push(m);
    }
    public void RestoreAction()
    {
        FolderItemMemento m=History.Pop();
        this.Clone(m.getState());
    }
    public virtual string ShowDetails()
    {
        return $"Name{Name} ,Size{Size}";
    }
    public virtual FolderItemContext Clone(FolderItemContext folderItem)
    {
        return new FolderItemContext( Name,Size);    
    }

    public  string Commit(CommandParams commandParams)
    {
        Console.WriteLine($"{commandParams.folderItem.Name} was commited succesfully");
        return folderItemState.Commit();
    }

    public  string Merge(CommandParams commandParams)
    {
        Console.WriteLine($"{commandParams.folderItem.Name} was merged succesfully");
        return folderItemState.Merge();
    }
    public string UndoCommit(CommandParams commandParams)
    {
        Console.WriteLine($"commit of {commandParams.folderItem.Name} was undone succesfully");
        return folderItemState.UndoCommit();
    }

    public string Add(CommandParams commandParams)
    {
        Console.WriteLine($"{commandParams.folderItem.Name} will go in to your next commit");
        return folderItemState.Add();
    }

}
