using Domain.Models;

namespace MinimalApi.Filters
{
    public class PostValidationFilter : IEndpointFilter
    {
        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var argumentIndex = FilterArgsUtil.GetArgumentIndex(context.Arguments, typeof(Post));
            var post = context.GetArgument<Post>(argumentIndex);
            if (string.IsNullOrEmpty(post.Content))
            {
                return await Task.FromResult(Results.BadRequest("Post not valid"));
            }

            return await next(context);
        }

    }
}
