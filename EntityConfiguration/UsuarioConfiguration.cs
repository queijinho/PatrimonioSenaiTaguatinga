using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PatrimonioSenaiTaguatinga;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Nome).IsRequired().HasMaxLength(80);
        builder.Property(u => u.Sobrenome).IsRequired().HasMaxLength(80);
        builder.Property(u => u.Login).IsRequired().HasMaxLength(80);
        builder.Property(u => u.Senha).IsRequired().HasMaxLength(80);
        builder.Property(u=>u.IdNivel).IsRequired();
        builder.HasOne(u => u.Nivel).WithMany(n => n.Usuarios).HasForeignKey(u => u.IdNivel);


    }
}