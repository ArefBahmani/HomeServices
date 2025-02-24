﻿using AppDomainCore.CommentEntite.Data;
using AppDomainCore.CommentEntite.Dtos;
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
        

        public async Task<bool> Creat(CommentCreateDto comment, CancellationToken cancellationToken)
        {
            var model = new Comment()
            {
                Reaction = comment.Reaction,
                Titel = comment.Title,
                Description = comment.Description,
                SaveTime = DateTime.Now,

            };
            if (model == null)
            {
                return false;
            }
            await _context.Comments.AddAsync(model,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
         
            return true;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
           var model = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.Comments.Include(x => x.IsDeleted == false).AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Comment> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.Comments.Include(x => x.IsDeleted == false).AsNoTracking().FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            return model;
        }

        public async Task<int> GetCount(CancellationToken cancellationToken)
        {
           var model = await _context.Comments.CountAsync(cancellationToken);
            return model;
        }

        public async Task<bool> SetReaction(int expertId, int reaction, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments.Include(x => x.IsDeleted == false).FirstOrDefaultAsync(e=>e.ExpertId == expertId,cancellationToken);
            if (comment == null)
            {
                return false;
            }
            comment.Reaction = reaction;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
            
        }

       

        public async Task<bool> Update(int id, CommentUpdateDto comment, CancellationToken cancellationToken)
        {
            var model = await _context.Comments.Include(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (model == null)
            {
                return false;
            }
            model = new Comment()
            {
                Reaction = comment.Reaction,
                Description = comment.Description,
                SaveTime = DateTime.Now,
                Titel = comment.Titel,

            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
