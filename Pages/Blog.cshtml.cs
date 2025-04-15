using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApp.Pages;

public class Blog : PageModel
{
    public string RequestMethod { get; set; }

    public string RequestValues { get; set; }
    
    public string Title { get; set; }
    
    public DateTime Date { get; set; }
    
    public string Body { get; set; }
    
    public void OnGet()
    {
        RequestMethod = "GET";
        RequestValues = "n/a";
        Title = "Cuban Midnight Sandwich";
        Date = new DateTime(2000, 3, 24);
        Body = "This sandwich is called a 'Media Noche' which translates to 'Midnight.' It makes a wonderful dinner sandwich because it is served hot. A nice side dish is black bean soup or black beans and rice, and plaintain chips.";
    }

    public void OnPost(string title, DateTime date, string body)
    {
        RequestMethod = "POST";
        RequestValues = GetFormValues();

        Title = title;
        Date = date;
        Body = body;
    }
    public string GetFormValues(bool ignoreRequestVerificationToken = true)
    {
        string formData = "";
        string separator = " | ";
        foreach (var pair in this.Request.Form)
        {
            if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
            {
                continue;
            }
            else
            {
                formData += pair.Key + ":" + Request.Form[pair.Key] + separator;
            }
        }

        if (formData.EndsWith(separator))
        {
            formData = formData.Substring(0, formData.Length - separator.Length);
        }
        return formData;
    }
}