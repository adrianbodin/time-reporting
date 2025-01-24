namespace TimeReporting.Pages.Shared;

public static class GlobalFragments
{
    public static string Toast(string message, ToastType type) =>
        // language=HTML
        $$"""
          <div id="toast" x-sync x-merge="append" class="toast-container position-fixed bottom-0 end-0 p-3" style="z-index: 1055;">
             <div id="liveToast" x-data="{ show: true }" x-show="show" x-init="setTimeout(() => show = false, 3000)" class="toast show text-bg-{{type.ToString().ToLower()}}" role="alert" aria-live="assertive" aria-atomic="true">
               <div class="d-flex">
                 <div class="toast-body">
                   {{message}}
                 </div>
                 <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
               </div>
             </div>
           </div>
          """;

    public static string Hello(string message) =>
        // language=HTML
        $$"""
           <div id="hello">
               {{ Heading(message) }}
           </div>
         """;

    private static string Heading(string message) =>
        // language=HTML
        $$"""
          <h1>{{ message }}</h1>
          """;

    public static string Num(int num) =>
        // language=HTML
        $$"""
             <div id="num" x-data="{ open: false }">
                 <button x-on:click="open = ! open">Show</button>
                 <h1 x-show="open" >The length of the type: {{num}}</h1>
             </div>
          """;
}

public enum ToastType
{
    Primary,
    Secondary,
    Success,
    Danger,
    Warning,
    Info,
    Light,
    Dark
}