using AutoMapper;
using MediatrCQRSpattern.Application.UseCases.MediumUser.Commands;
using MediatrCQRSpattern.Domain.DTOs;
using MediatrCQRSpattern.Domain.Entities;
using System.Reflection;

namespace MediatrCQRSpattern.Application.Mappers
{
    public static class AutoMapperProfile
    {
        public static TEntity Map<TEntity>(this object entity)
        {
            var newEntity = Activator.CreateInstance<TEntity>();
            var typeNewEntity = newEntity.GetType();
            var typeObject = entity.GetType();

            PropertyInfo[] properties = typeNewEntity.GetProperties();

            foreach (var property in properties)
            {
                var objectProperty = typeObject.GetProperty(property.Name);

                if (objectProperty != null)
                    property.SetValue(newEntity, objectProperty.GetValue(entity));
            }

            return (TEntity)newEntity;
        }
    }
}
