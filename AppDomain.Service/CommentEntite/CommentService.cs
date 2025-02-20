using AppDomainCore.CommentEntite.Data;
using AppDomainCore.CommentEntite.Dtos;
using AppDomainCore.CommentEntite.Entite;
using AppDomainCore.CommentEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.CommentEntite
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task<bool> Creat(CommentCreateDto comment, CancellationToken cancellationToken)
        {
            return await _commentRepository.Creat(comment, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _commentRepository.Delete(id, cancellationToken);
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
           return await _commentRepository.GetAll(cancellationToken);
        }

        public async Task<Comment> GetById(int id, CancellationToken cancellationToken)
        {
           return await _commentRepository.GetById(id, cancellationToken);
        }

        public async Task<int> GetCount(CancellationToken cancellationToken)
        {
            return await _commentRepository.GetCount(cancellationToken);
        }

        public async Task<bool> SetReaction(int expertId, int reaction, CancellationToken cancellationToken)
        {
            return await _commentRepository.SetReaction(expertId, reaction, cancellationToken);
        }

        public async Task<bool> Update(int id, CommentUpdateDto comment, CancellationToken cancellationToken)
        {
            return await _commentRepository.Update(id, comment, cancellationToken);
        }
    }
}
