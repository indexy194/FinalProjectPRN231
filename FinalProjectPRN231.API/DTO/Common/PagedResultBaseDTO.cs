namespace FinalProjectPRN231.API.DTO.Common
{
    public class PagedResultBaseDTO
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public int MaxSetting { get; set; }
        public int FirstRowOnPage
        {
            get { return Math.Min(RowCount, (CurrentPage - 1) * PageSize + 1); }
        }
        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * PageSize, RowCount); }
        }
    }
}
