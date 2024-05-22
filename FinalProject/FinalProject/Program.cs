using FinalProject.BasicClasses;
using FinalProject.Command;
using FinalProject.Composite;
using FinalProject.Flyweight;
using FinalProject.State;

User user1 = new User("Sara","Sara45","sara456@gmail.com");
User user2 = new User("Chaya", "Chaya1234", "chaya1234@gmail.com");
User user3 = new User("Lea", "Lea9876", "Lea9876@gmail.com");
User user4 = new User("Chana", "Chana4583", "chana4583@gmail.com");

FolderComposite folder1 = new FolderComposite("Folder1",23);
FolderComposite folder2 = new FolderComposite("Folder2",45);
FileItem file1 = new FileItem("File1",89);
FileItem file2 = new FileItem("File2",34);
FileItem file3 = new FileItem("File3",23);

folder1.AddItem(folder2);
folder2.AddItem(file2);
folder2.AddItem(file3);

List<FolderItemContext> list1 = new List<FolderItemContext>() { folder1, file1, file2 };
List<FolderItemContext> list2 = new List<FolderItemContext>() { file1, file2, file3 };
FolderItemState itemsState1 = new Modified(list1[0]);
FolderItemState itemsState2 = new Modified(list2[0]);

Repository repository1 = new Repository(true, list1,user1);
Console.WriteLine(repository1.Main.FlyweightBranch.itemsOriginators[0].ShowDetails());
CommandParams commandParams = new CommandParams();
folder1.Add(commandParams);
folder1.Commit(commandParams);
folder1.Add(commandParams);

folder1.SaveAction();
file1.SaveAction();
folder1.RestoreAction();
repository1.AddBranch("development", repository1.branches[0].Name);
