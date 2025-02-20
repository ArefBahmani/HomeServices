using AppDomainCore.CommentEntite.AppService;
using AppDomainCore.CommentEntite.Dtos;
using AppDomainCore.CommentEntite.Entite;
using AppDomainCore.CommentEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.CommentEntite
{
    public class CommentAppService : ICommentAppService
    {
        private readonly ICommentService _commentService;
        public CommentAppService(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<bool> Creat(CommentCreateDto comment, CancellationToken cancellationToken)
        {
           return await _commentService.Creat(comment, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _commentService.Delete(id, cancellationToken);
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            return await _commentService.GetAll(cancellationToken);
        }

        public async Task<Comment> GetById(int id, CancellationToken cancellationToken)
        {
            return await _commentService.GetById(id, cancellationToken);
        }

        public async Task<int> GetCount(CancellationToken cancellationToken)
        {
            return await _commentService.GetCount(cancellationToken);
        }

        public async Task<bool> SetReaction(int expertId, int reaction, CancellationToken cancellationToken)
        {
            return await _commentService.SetReaction(expertId, reaction, cancellationToken);
        }

        public async Task<bool> Update(int id, CommentUpdateDto comment, CancellationToken cancellationToken)
        {
            return await _commentService.Update(id, comment, cancellationToken);    
        }
    }
}
