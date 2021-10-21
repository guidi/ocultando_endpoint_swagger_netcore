using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace WebApplication1
{
    public class RemoverExcluirSwaggerFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            //Pegamos todas as rotas que contenham excluir
            var rotasParaEsconder = swaggerDoc.Paths
                .Where(x => x.Key.ToLower().Contains("excluir"))
                .ToList();

            rotasParaEsconder.ForEach(x => { swaggerDoc.Paths.Remove(x.Key); });
        }
    }
}
