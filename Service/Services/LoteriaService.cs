﻿using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Service.Services
{
    public abstract class LoteriaService<T> : ILoteriaService<T> where T : LoteriaAbstract 
    {
        private readonly ILoteriaRepository<LoteriaDocument> _repository;
        public LoteriaService(ILoteriaRepository<LoteriaDocument> repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<LoteriaAbstract>> GetAsync()
        {
            var document = await _repository.GetAsync();
            var models = document.Select(x => x.ToModel());
            return models;
        }

        public async Task<LoteriaAbstract> GetLastAsync()
        {
            var document = await _repository.GetLastAsync();
            return document.ToModel();
        }

        public async Task<IEnumerable<LoteriaAbstract>> FilterByNumeroAsync(int numero)
        {
            var document = await _repository.FilterByNumeroAsync(numero);
            var models = document.Select(x => x.ToModel());
            return models;
        }
    }

}
