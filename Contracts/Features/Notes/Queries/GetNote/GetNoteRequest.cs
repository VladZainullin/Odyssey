using Contracts.Features.Notes.Queries.GetNotes;
using MediatR;

namespace Contracts.Features.Notes.Queries.GetNote;

public sealed record GetNoteRequest(GetNotesRequestDto Dto) : IRequest<GetNotesResponseDto>;