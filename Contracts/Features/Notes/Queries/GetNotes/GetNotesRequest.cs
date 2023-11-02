using MediatR;

namespace Contracts.Features.Notes.Queries.GetNotes;

public sealed record GetNotesRequest(GetNotesRequestDto Dto) : IRequest<GetNotesResponseDto>;