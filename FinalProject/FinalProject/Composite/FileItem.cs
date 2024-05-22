using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Composite;

public class FileItem : FolderItemContext
{
    public FileItem(string name, double size ) : base(name, size)
    {
    }
    public override string ShowDetails()
    {
        return base.ShowDetails();
    }
    public override FolderItemContext Clone(FolderItemContext folderItem)
    {
        return base.Clone(folderItem);
    }
}
