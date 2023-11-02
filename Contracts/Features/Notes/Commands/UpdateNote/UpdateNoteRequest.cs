using MediatR;

namespace Contracts.Features.Notes.Commands.UpdateNote;

public sealed record UpdateNoteRequest(UpdateNoteRequestDto Dto) : IRequest<UpdateNoteResponseDto>;