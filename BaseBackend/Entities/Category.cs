using BaseBackend.Entities;
using BaseBackend.Entities.Interfaces;

namespace LearnCSharpInSematec.Models;

public partial class Category : IBaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
