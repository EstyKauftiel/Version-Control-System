using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State
{
    public class Merged:FolderItemState
    {
 

        public Merged(FolderItemContext folderItemContext) : base(folderItemContext)
        {
        }

        public override string Commit()
        {
            return "Already merged, can not commit now...";
        }
        public override string Merge()
        {
            return "Already merged";
        }
        public override string UndoCommit()
        {
            return "Already merged, can not undo commit now...";
        }

        public override string Add()
        {
            return "Already merged, can not add now...";
        }

        //public override string Write()
        //{
        //    throw new NotImplementedException();
        //}
        //public override string Delete()
        //{
        //    throw new NotImplementedException();
        //}
        //public override string Read()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
