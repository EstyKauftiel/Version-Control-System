using FinalProject.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.BasicClasses;

public interface ICollaborator
{
    public string Review(BranchContext branchContext1, BranchContext branchContext2);
}
