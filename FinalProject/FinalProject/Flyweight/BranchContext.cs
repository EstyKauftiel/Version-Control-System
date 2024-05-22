using FinalProject.BasicClasses;
using FinalProject.Composite;
using FinalProject.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Flyweight;

public class BranchContext
{
    private Repository flyweightBranchFactory;
    public FlyweightBranch FlyweightBranch { get;  }
    public List<FolderItemContext> ChangedItems { get; }
    public string Name { get; set; }

    public BranchContext(string name, List<FolderItemContext> Items, Repository repo)
    {
        this.Name = name;
        flyweightBranchFactory=repo;
        FlyweightBranch= flyweightBranchFactory.GetFlyweightBranch(Items);
        ChangedItems =new List<FolderItemContext>();
    }
}
