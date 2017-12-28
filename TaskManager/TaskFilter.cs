using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TaskManager
{
    public class TaskFilter
    {
        private CollectionViewSource _taskViewSource;


        public TaskFilter(CollectionViewSource taskViewSource)
        {
            this._taskViewSource = taskViewSource;
        }

        public ICollectionView FiltrPriority(TaskPriority priority)
        {
            _taskViewSource.Filter += new FilterEventHandler((sender, e) => PriorityFilterImp(sender, e, (int)priority));
            ICollectionView Itemlist = _taskViewSource.View;
            return Itemlist;
        }

        private void PriorityFilterImp(object sender, FilterEventArgs e, int priority)
        {
            var obj = e.Item as Task;
            if (obj != null)
            {
                if (obj.priority == priority)
                    e.Accepted = true;
                else
                    e.Accepted = false;
            }
        }

        public ICollectionView FiltrStatus(TaskStatus status)
        {
            _taskViewSource.Filter += new FilterEventHandler((sender, e) => StatusFilterImp(sender, e, (int)status));
            ICollectionView Itemlist = _taskViewSource.View;
            return Itemlist;
        }

        private void StatusFilterImp(object sender, FilterEventArgs e, int status)
        {
            var obj = e.Item as Task;
            if (obj != null)
            {
                if (obj.status == status)
                    e.Accepted = true;
                else
                    e.Accepted = false;
            }
        }

        public ICollectionView ShowAll()
        {
            _taskViewSource.Filter += new FilterEventHandler(ShowAllFilterImp);
            ICollectionView Itemlist = _taskViewSource.View;
            return Itemlist;
        }

        private void ShowAllFilterImp(object sender, FilterEventArgs e)
        {
            var obj = e.Item as Task;
            if (obj != null)
            {
                e.Accepted = true;
            }
        }
    }
}
