using System.Collections.Generic;
using Dataocean.Venus.Auditing.Dto;
using Dataocean.Venus.Dto;

namespace Dataocean.Venus.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}

