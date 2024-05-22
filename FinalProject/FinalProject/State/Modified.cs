using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State;


//זה כמו class של טיוטה
public class Modified:FolderItemState
{
    public Modified(FolderItemContext folderItemContext) : base(folderItemContext)
    {
    }

    public override string Add()
    {
        folderItemContext.ChangeState(new Staged(folderItemContext));
        return "";
    }
    public override string Commit()
    {
        return "Can not commit yet, you need to add the file first";
    }
    

    public override string Merge()
    {
        return "Can not merge yet, you need to add the file first and commit it";
    }
    public override string UndoCommit()
    {
        return "No commit to undo";
    }


}
