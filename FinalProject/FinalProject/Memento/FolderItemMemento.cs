using FinalProject.Composite;
using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento;

public class FolderItemMemento
{
    private FolderItemContext folderItemContext;
    public FolderItemMemento(FolderItemContext folderItemContext)
    {
        this.folderItemContext = folderItemContext;
    }
    public FolderItemContext getState()
    {
        return folderItemContext;
    }
}
