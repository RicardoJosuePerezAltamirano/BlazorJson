
using Microsoft.AspNetCore.Components;

namespace BlazorJson.Components
{
    public partial class DataComponent
    {
        [Inject]
        public HttpClient Client { get; set; }

        public List<Model> DataModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var data = await Client.
                GetFromJsonAsync<List<Model>>
                ("https://raw.githubusercontent.com/BryanOroxon/data/main/pets.json");
            if (data != null)
            {
                DataModel = data;
                
            }
        }
    }
}
