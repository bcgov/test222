using myappwebapi.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace myappwebapi.Features.Participant;

public class Application
{
    public sealed record ApplicationQuery() : IQuery<List<ApplicationType>>;
    [Table("type_application", Schema = "public")]
    public class ApplicationType
    {
        [Key]
        [Column("code")]
        public string code { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("birthdate")]
        public DateTime BirthDate { get; set; }
    }
    public class QueryHandler : IQueryHandler<ApplicationQuery, List<ApplicationType>>
    {
        private readonly myappwebapiDataContext context;

        public QueryHandler(myappwebapiDataContext context) => this.context = context;

        public async Task<List<ApplicationType>> HandleAsync(ApplicationQuery query)
        {
            return await this.context.ApplicationTypes
            .ToListAsync();
        }
    }
}
