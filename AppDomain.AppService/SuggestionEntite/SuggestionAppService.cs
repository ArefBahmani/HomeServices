using AppDomainCore.SuggestionEntite.AppService;
using AppDomainCore.SuggestionEntite.Dtos;
using AppDomainCore.SuggestionEntite.Entite;
using AppDomainCore.SuggestionEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.SuggestionEntite
{
    public class SuggestionAppService : ISuggestionAppService
    {
        private readonly ISuggestionService _suggestionService;
        public SuggestionAppService(ISuggestionService suggestionService)
        {
            _suggestionService = suggestionService;
        }
        public async Task<bool> Create(CeateSuggestionDto suggestion, CancellationToken cancellationToken)
        {
            return await _suggestionService.Create(suggestion, cancellationToken);
        }

        public async Task<bool> Delete(int suggestionId, CancellationToken cancellationToken)
        {
           return await _suggestionService.Delete(suggestionId, cancellationToken);
        }

        public async Task<List<Suggestion>> GetAll(CancellationToken cancellationToken)
        {
            return await _suggestionService.GetAll(cancellationToken);
        }

        public async Task<Suggestion> GetById(int id, CancellationToken cancellationToken)
        {
            return await _suggestionService.GetById(id, cancellationToken);
        }

        public async Task<bool> Update(int suggestionId, UpdateSuggestionDto suggestion, CancellationToken cancellationToken)
        {
            return await _suggestionService.Update(suggestionId, suggestion, cancellationToken);
        }
    }
}
