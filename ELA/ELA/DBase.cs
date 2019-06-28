using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using ELA.Models;

namespace ELA
{
    public class DBase
    {
        readonly SQLiteAsyncConnection _bancotexto;
        public DBase(string Path)
        {
            _bancotexto = new SQLiteAsyncConnection(Path);
            _bancotexto.CreateTableAsync<Models.Texto>().Wait();
        }

        public Task<List<Texto>> Listar()
        {
            return _bancotexto.Table<Texto>().ToListAsync();
        }
        public Task<Texto> Listar(int id)
        {
            return _bancotexto.Table<Texto>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> Adicionar(Texto t)
        {
            return _bancotexto.InsertAsync(t);
        }
        public Task<int> Deletar(Texto t)
        {
            return _bancotexto.DeleteAsync(t);
        }
    }
}