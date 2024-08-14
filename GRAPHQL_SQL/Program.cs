using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GRAPHQL_SQL.DB;
using GRAPHQL_SQL.Interfaces;
using GRAPHQL_SQL.Mutation;
using GRAPHQL_SQL.Query;
using GRAPHQL_SQL.Resolver;
using GRAPHQL_SQL.Schema;
using GRAPHQL_SQL.Services;
using GRAPHQL_SQL.Type;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        // Product Configurations
        builder.Services.AddTransient<IProductResolver, ProductResolver>();
        builder.Services.AddTransient<ProductType>();
        builder.Services.AddTransient<ProductInputType>();
        builder.Services.AddTransient<ProductQuery>();
        builder.Services.AddTransient<ProductMutation>();

        //Student Configurations
        builder.Services.AddTransient<IStudentResolver, StudentResolver>();
        builder.Services.AddTransient<StudentType>();
        builder.Services.AddTransient<StudentQuery>();

        //Root Configurations
        builder.Services.AddTransient<AppQuery>();
        builder.Services.AddTransient<AppMutation>();
        builder.Services.AddTransient<ISchema, RootSchema>();

        builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson().AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = true));

        builder.Services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("GraphQLDbContextConnection")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseHttpsRedirection();

        app.UseGraphiQl("/graphql");
        app.UseGraphQL<ISchema>();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}