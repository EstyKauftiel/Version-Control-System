using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command;

public class AddCommand : AbstractCommand
{
    public AddCommand(FolderItemContext receiver) : base(receiver)
    {
        
    }
    public override string Execute(CommandParams commandParams)
    {
        return Receiver.Add(commandParams);
    }
}
