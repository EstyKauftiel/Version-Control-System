using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State
{
    public class Commited : FolderItemState
    {
       

        public Commited(FolderItemContext folderItemContext) : base(folderItemContext)
        {
            
        }

        public override string Commit()
        {
           
            return "Already commited";
        }


        //public override string Delete()
        //{
        //   context.Delete();
        //}

        public override string Merge()
        {

            folderItemContext.ChangeState(new Merged(folderItemContext));
            return "";
        }

        //public override string Read()
        //{
        //    context.Read();
        //}

        public override string UndoCommit()
        {
            folderItemContext.ChangeState(new Staged(folderItemContext));
            return "";
        }

        public override string Add()
        {
            return "Already added";
        }

        //public override string Write()
        //{
        //    context.Write();
        //}
    }
}
