using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State
{
    public abstract class FolderItemState
    {
        protected FolderItemContext folderItemContext;
        public FolderItemState(FolderItemContext folderItemContext)
        {
            this.folderItemContext = folderItemContext;
        }
        public abstract string Merge();
        public abstract string Commit();
        public abstract string UndoCommit();
        public abstract string Add();

    }
}
