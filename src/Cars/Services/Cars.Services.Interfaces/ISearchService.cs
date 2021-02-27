using Cars.Models;

namespace Cars.Services.Interfaces
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.10.6.0 (NJsonSchema v10.3.8.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial interface ISearchService
    {
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Category>> GetCategoriesAsync();

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Category>> GetCategoriesAsync(System.Threading.CancellationToken cancellationToken);

        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Vehicle>> GetPopularCarsAsync();

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Vehicle>> GetPopularCarsAsync(System.Threading.CancellationToken cancellationToken);

    }
}
