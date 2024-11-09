using BOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

public class IndexModel : PageModel
{
    private readonly IFlowerService _flowerService;
    public List<Flower> Flowers { get; set; }
    public string SearchString { get; set; }
    public int PageIndex { get; set; } = 1;  // Default to page 1
    public int TotalPages { get; set; }
    public int PageSize { get; set; } = 4;

    public IndexModel(IFlowerService flowerService)
    {
        _flowerService = flowerService;
    }

    public void OnGet(string searchString, int pageIndex = 1)
    {
        SearchString = searchString;
        PageIndex = pageIndex;

        // Get flowers with pagination
        Flowers = _flowerService.GetFlowers(searchString ?? "", "desc", "createdAt", (pageIndex - 1) * PageSize, PageSize, "");

        // Get total number of flowers to calculate total pages
        var allProfiles = _flowerService.GetFlowers(searchString ?? "", "desc", "createdAt", 0, 99999, "");
        var totalProfiles = allProfiles.Count();
        TotalPages = (int)Math.Ceiling(totalProfiles / (double)PageSize);
    }
}
