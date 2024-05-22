using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State
{
    public class Staged:FolderItemState
    {
       
        public Staged(FolderItemContext folderItemContext):base(folderItemContext) 
        {
      
        }

        public override string Commit()
        {
            folderItemContext.ChangeState(new Commited(folderItemContext));
            return "commited";
        }
        public override string Merge()
        {
            return "needs to be commited";
        }
        public override string UndoCommit()
        {
            return "was not commited yet";
        }

        public override string Add()
        {
            return "already added";
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
