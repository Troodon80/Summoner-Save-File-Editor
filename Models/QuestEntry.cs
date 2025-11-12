public class QuestEntry
{
    public int QuestId { get; set; }
    public string Name { get; set; }
    public bool Visible { get; set; }
    
    public override string ToString()
    {
        return $"{QuestId}: {Name}";
    }
    
    public ListViewItem ToListViewItem()
    {
        var item = new ListViewItem(Name) { Tag = this, Checked = Visible };
        item.SubItems.Add(QuestId.ToString());
        return item;
    }
}