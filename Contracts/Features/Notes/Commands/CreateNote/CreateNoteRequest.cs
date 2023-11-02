using MediatR;

namespace Contracts.Features.Notes.Commands.CreateNote;

public sealed record CreateNoteRequest(CreateNoteRequestDto Dto) : IRequest<CreateNoteResponseDto>;