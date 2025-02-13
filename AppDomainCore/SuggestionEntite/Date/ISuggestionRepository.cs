using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.SuggestionEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SuggestionEntite.Date
{
    public interface ISuggestionRepository
    {
        public Task<bool> Create(Suggestion suggestion, CancellationToken cancellationToken);
        public Task<bool> Delete(int suggestionId, CancellationToken cancellationToken);
        public Task<bool> Update(int suggestionId, Suggestion suggestion, CancellationToken cancellationToken);
        public Task<Suggestion> GetById(int id, CancellationToken cancellationToken);
        public Task<List<Suggestion>> GetAll(CancellationToken cancellationToken);
    }
}
