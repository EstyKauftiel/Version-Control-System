using FinalProject.Composite;
using FinalProject.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProject.Flyweight;

public class FlyweightBranch
{
    public List<FolderItemContext> itemsOriginators;
    public FlyweightBranch(List<FolderItemContext> itemsOriginators)
    {
        this.itemsOriginators = itemsOriginators;
    }
}
