using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

file sealed class NoteLabelConfiguration : IEntityTypeConfiguration<NoteLabel>
{
    public void Configure(EntityTypeBuilder<NoteLabel> builder)
    {
        builder.HasKey(nameof(Note) + "Id", nameof(Label) + "Id");
    }
}