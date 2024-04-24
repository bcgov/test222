namespace myappwebapi.Features;

public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
{
    new Task<TResult> HandleAsync(TQuery query);
}
