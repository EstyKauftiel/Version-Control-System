using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command;

public abstract class AbstractCommand
{
    public FolderItemContext Receiver { get; set; }
    public AbstractCommand(FolderItemContext receiver)
    {
        Receiver = receiver;
    }
    public abstract string Execute(CommandParams commandParams);
}

