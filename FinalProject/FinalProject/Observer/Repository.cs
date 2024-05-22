using FinalProject.Composite;
using FinalProject.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BasicClasses;

public class Repository
{
    public User User { get; set; }
    public List<BranchContext> branches;
    private List<ICollaborator> collaborators;
    public BranchContext Main { get; set; }
    public bool Accsses { get; set; }
    public Repository(bool accsses,List<FolderItemContext> folderItemContexts,User user)
    {
        branches = new List<BranchContext>();
        Main = new BranchContext("main", folderItemContexts, this);
        branches.Add(Main);
        collaborators = new List<ICollaborator>();
        Accsses = accsses;
        User = user;
    }
    public void AddCollaborator(ICollaborator collaborator)
    {
        collaborators.Add(collaborator);
    }
    public void RemoveCollaborator(ICollaborator collaborator)
    {
        foreach (ICollaborator c in collaborators)
        {
            if ((c as User).Name == (collaborator as User).Name)
            {
                collaborators.Remove(c);
            }
        }
    }
    public void AddBranch(string branchName,string copyBranchName)
    {
        foreach(BranchContext b in branches)
        {
            if (b.Name == copyBranchName)
                branches.Add(new BranchContext(branchName,b.FlyweightBranch.itemsOriginators, this));
        }      
    }
    public void RemoveBranch(string branchName) 
    { 
        branches.Remove(branches.FirstOrDefault(b => b.Name == branchName));
    }
    public void RequestReview(string branchName1, string branchName2, ICollaborator collaborator)
    {
        Console.WriteLine($"a request review was sent to {(collaborator as User).Name}");
        string review= collaborator.Review(branches.FirstOrDefault(b => b.Name == branchName1), branches.FirstOrDefault(b => b.Name == branchName2));
        Console.WriteLine(review);  // in reality the review will return only once the collaborator sends a review...
    }
    public FlyweightBranch GetFlyweightBranch(List<FolderItemContext> folderItemContexts)
    {
        bool flag = false;
        FlyweightBranch flyweightBranch = null;
        foreach (BranchContext f in branches)
        {
            for (int i = 0; i < folderItemContexts.Count; i++)
            {
                if (f.FlyweightBranch.itemsOriginators[i] != folderItemContexts[i])
                    flag = true;
            }
            if (!flag)
            {
                flyweightBranch = f.FlyweightBranch;
                break;
            }
        }
        if (flag)
            flyweightBranch = new FlyweightBranch(folderItemContexts);
        return flyweightBranch;
    }
}
