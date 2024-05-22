using FinalProject.Command;
using FinalProject.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalProject.BasicClasses;

public class User:ICollaborator
{
    public string Name { get; set; }
    private string Password { get; set; }
    public string Email { get; set; }
    public Queue<AbstractCommand> Commands { get; set; }
    public Queue<CommandParams> CommandParams { get; set; }

    public List<Repository> repositorys;
    public User(string name,string password,string email)
    {
        repositorys = new List<Repository>();
    }
    public string Review(BranchContext branchContext1, BranchContext branchContext2)
    {
        //the user sends back his opinion on the branches
        return "My opinion is:    ...     ";
    }
    public void AddRepsitory(Repository repository)
    {
        repositorys.Add(repository);
    }
    
    public void EnterTheQueue(CommandParams commandParams, AbstractCommand abstractCommand)
    {
        Commands.Enqueue(abstractCommand);
        CommandParams.Enqueue(commandParams);
    }
    public void SetCommand(AbstractCommand command)
    {
       //command = command;
    }
    public void ExecuteCommands()
    {
        while (Commands.Count > 0)
        {
            AbstractCommand command = Commands.Dequeue();
            CommandParams commandParams=CommandParams.Dequeue();
            command.Execute(commandParams);
        }
    }
}
