using System.Collections.Generic;
using Dataocean.Venus.Chat.Dto;
using Dataocean.Venus.Dto;

namespace Dataocean.Venus.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}

