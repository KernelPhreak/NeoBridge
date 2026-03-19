namespace NeoBridge.Models;

internal class ProjectModel
{
    public string ProjectName { get; set; } = string.Empty;
    public string ProjectPath { get; set; } = string.Empty;
    public string ProjectGuid { get; set; } = string.Empty;
    public string ExportPath { get; set; } = string.Empty;
    public bool ShowOnImport { get; set; } = true;
    public bool RenameOnExport { get; set; } = true;
    public string RenamePattern { get; set; } = "{original_name}_{timestamp}";
}
