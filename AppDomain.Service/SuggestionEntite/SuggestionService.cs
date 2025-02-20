using AppDomainCore.SuggestionEntite.Date;
using AppDomainCore.SuggestionEntite.Dtos;
using AppDomainCore.SuggestionEntite.Entite;
using AppDomainCore.SuggestionEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.SuggestionEntite
{
    public class SuggestionService : ISuggestionService
    {
        private readonly ISuggestionRepository _suggestionRepository;
        public SuggestionService(ISuggestionRepository suggestionRepository)
        {
            _suggestionRepository = suggestionRepository;
        }
        public async Task<bool> Create(CeateSuggestionDto suggestion, CancellationToken cancellationToken)
        {
            return await _suggestionRepository.Create(suggestion, cancellationToken);
        }

        public async Task<bool> Delete(int suggestionId, CancellationToken cancellationToken)
        {
            return await _suggestionRepository.Delete(suggestionId, cancellationToken);
        }

        public async Task<List<Suggestion>> GetAll(CancellationToken cancellationToken)
        {
            return await _suggestionRepository.GetAll(cancellationToken);
        }

        public async Task<Suggestion> GetById(int id, CancellationToken cancellationToken)
        {
            return await _suggestionRepository.GetById(id, cancellationToken);
        }

        public async Task<bool> Update(int suggestionId, UpdateSuggestionDto suggestion, CancellationToken cancellationToken)
        {
            return await _suggestionRepository.Update(suggestionId, suggestion, cancellationToken);
        }
    }
}
