using AppDomainCore.CommentEntite.Data;
using AppDomainCore.CommentEntite.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.CommentEntite
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;
        public CommentRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Creat(Comment comment, CancellationToken cancellationToken)
        {
            var model = new Comment()
            {
                Reaction = comment.Reaction,
                Titel = comment.Titel,
                SaveTime = DateTime.Now,

            };
            await _context.Comments.AddAsync(model);
           await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
           var model = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.Comments.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Comment> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.Comments.AsNoTracking().FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            return model;
        }

        public async Task<int> GetCount(CancellationToken cancellationToken)
        {
           var model = await _context.Comments.CountAsync(cancellationToken);
            return model;
        }

        public async Task<bool> SetReaction(int expertId, int reaction, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(e=>e.ExpertId == expertId,cancellationToken);
            comment.Reaction = reaction;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
            
        }

        public async Task<bool> Update(int id, Comment comment, CancellationToken cancellationToken)
        {
           var model = await _context.Comments.FirstOrDefaultAsync(x=> x.Id == id,cancellationToken);

            model = new Comment()
            {
                Reaction = comment.Reaction,
                SaveTime = DateTime.Now,
                Titel = comment.Titel,

            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
