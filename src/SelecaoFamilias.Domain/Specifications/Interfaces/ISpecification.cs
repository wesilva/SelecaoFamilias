namespace SelecaoFamilias.Domain.Specifications
{
    public interface ISpecification<in T>
    {       
        public abstract void ValidarCriterio(T entity);
    }
}
