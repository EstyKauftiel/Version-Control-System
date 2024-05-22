using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Composite;

public class FolderComposite : FolderItemContext
{
    private List<FolderItemContext> items;
    public FolderComposite(string name, double size) : base(name, size)
    {
        items = new List<FolderItemContext>();
    }
    public void AddItem(FolderItemContext item)
    {
        items.Add(item);
    }
    public void RemoveItem(FolderItemContext item)
    {
        foreach (FolderItemContext i in items)
        {
            items.Remove(i);
        }
    }
    public override string ShowDetails()
    {
        return base.ShowDetails();
    }
    //public override FolderComposite Clone(FolderItemContext folder)
    //{
    //    //FolderComposite folderComposite=new()
    //    ////foreach(FolderItemContext item in folder.items)
    //    ////    folderComposite.items.Add(base.Clone(item));
    //    ///th
    //    throw new NotImplementedException();
    //}
}
