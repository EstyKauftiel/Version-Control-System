using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State
{
    public class UnderReview : FolderItemState
    {
       
        public UnderReview(FolderItemContext folderItemContext):base(folderItemContext) { }
       

        public override string Commit()
        {
            return "already commited";
        }
        public override string Merge()
        {
            folderItemContext.ChangeState(new Merged(folderItemContext));
            return "merged";
        }
        public override string UndoCommit()
        {
            return "can not undo commit now";
        }

        public override string Add()
        {
            return "can not undo add now";
        }

        //public override string Write()
        //{
        //    context.Write();
        //}
        //public override string Delete()
        //{
        //    context.Delete();
        //}
        //public override string Read()
        //{
        //    context.Read();
        //}
    }
}
