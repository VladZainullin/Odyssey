using MediatR;

namespace Contracts.Features.Notes.Commands.DeleteNote;

public sealed record DeleteNoteRequest(DeleteNoteRequestDto Dto) : IRequest;