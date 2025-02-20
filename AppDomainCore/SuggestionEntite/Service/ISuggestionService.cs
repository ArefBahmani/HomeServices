using AppDomainCore.SuggestionEntite.Dtos;
using AppDomainCore.SuggestionEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SuggestionEntite.Service
{
    public interface ISuggestionService
    {
        public Task<bool> Create(CeateSuggestionDto suggestion, CancellationToken cancellationToken);
        public Task<bool> Delete(int suggestionId, CancellationToken cancellationToken);
        public Task<bool> Update(int suggestionId, UpdateSuggestionDto suggestion, CancellationToken cancellationToken);
        public Task<Suggestion> GetById(int id, CancellationToken cancellationToken);
        public Task<List<Suggestion>> GetAll(CancellationToken cancellationToken);
    }
}
