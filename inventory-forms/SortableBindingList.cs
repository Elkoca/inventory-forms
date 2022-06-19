using System.ComponentModel;

namespace inventory_forms;

public class SortableBindingList<T> : BindingList<T>
{
    private bool _isSortedValue;
    private ListSortDirection _sortDirectionValue;
    private PropertyDescriptor _sortPropertyValue;
    //private IList<T> _originalSorting;

    public SortableBindingList()
    {
    }

    public SortableBindingList(IList<T> list)
    {
        //_originalSorting = list;
        foreach (T o in list)
        {
            this.Add(o);
        }
    }

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {

        Type? interfaceType = prop.PropertyType.GetInterface("IComparable");


        if (interfaceType != null)
        {
            _sortPropertyValue = prop;
            _sortDirectionValue = direction;

            IEnumerable<T> query = this.Items;

            if (direction == ListSortDirection.Ascending)
            {
                //API Kall
                query = query.OrderBy(i => prop.GetValue(i));
            }
            else
            {
                //API Kall
                query = query.OrderByDescending(i => prop.GetValue(i));
            }


            int newIndex = 0;
            foreach (T item in query)
            {
                this.SetItem(newIndex, item);
                newIndex++;
            }

            _isSortedValue = true;
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        else
        {
            throw new NotSupportedException("Cannot sort by " + prop.Name + ". This" + prop.PropertyType.ToString() + " does not implement IComparable");
        }
    }

    //Not sure if needed
    //protected override void RemoveSortCore()
    //{
    //    int newIndex = 0;
    //    foreach (T item in _originalSorting)
    //    {
    //        this.SetItem(newIndex, item);
    //        newIndex++;
    //    }
    //    _isSortedValue = false;
    //    this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
    //}

    protected override PropertyDescriptor SortPropertyCore
    {
        get { return _sortPropertyValue; }
    }

    protected override ListSortDirection SortDirectionCore
    {
        get { return _sortDirectionValue; }
    }

    protected override bool SupportsSortingCore
    {
        get { return true; }
    }

    protected override bool IsSortedCore
    {
        get { return _isSortedValue; }
    }
}
