﻿using AppDomainCore.CommentEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CommentEntite.Data
{
    public interface ICommentRepository
    {
        public Task<Comment> GetById(int id,CancellationToken cancellationToken);
        public Task<bool> Creat(Comment comment, CancellationToken cancellationToken);
        public Task<bool> Delete(int id,CancellationToken cancellationToken);
        public Task<List<Comment>> GetAll(CancellationToken cancellationToken);
        public Task<bool> Update(int id,Comment comment, CancellationToken cancellationToken);
        public Task<bool> SetReaction(int expertId,int reaction,CancellationToken cancellationToken);
        public Task<int> GetCount(CancellationToken cancellationToken);

    }
}
