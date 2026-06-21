"""Generate a draw.io class diagram for the diplom WinForms project."""
from pathlib import Path
import html


FONT = "Arial"


def class_box(cid, x, y, w, h, name, attrs=None, methods=None, stereotype=None, fill="#ffffff"):
    attrs = attrs or []
    methods = methods or []
    lines = []
    if stereotype:
        lines.append(f'<p style="margin:0;text-align:center;color:#666666;">&lt;&lt;{html.escape(stereotype)}&gt;&gt;</p>')
    lines.append(f'<p style="margin:0;margin-top:4px;text-align:center;"><b>{html.escape(name)}</b></p>')
    lines.append('<hr size="1" style="border-style:solid;"/>')
    if attrs:
        for attr in attrs:
            lines.append(f'<p style="margin:0 0 0 6px;">{html.escape(attr)}</p>')
        lines.append('<hr size="1" style="border-style:solid;"/>')
    elif methods:
        lines.append('<p style="margin:0 0 0 6px;color:#888888;">&nbsp;</p>')
        lines.append('<hr size="1" style="border-style:solid;"/>')
    for method in methods:
        lines.append(f'<p style="margin:0 0 0 6px;">{html.escape(method)}</p>')

    value = html.escape("".join(lines), quote=True)
    style = (
        "rounded=0;whiteSpace=wrap;html=1;verticalAlign=top;align=left;"
        f"fontSize=12;fontFamily={FONT};fillColor={fill};strokeColor=#444444;"
    )
    return f"""        <mxCell id="{cid}" value="{value}" style="{style}" vertex="1" parent="1">
          <mxGeometry x="{x}" y="{y}" width="{w}" height="{h}" as="geometry" />
        </mxCell>"""


def edge(eid, source, target, label="", relation="dependency"):
    style = f"html=1;fontFamily={FONT};rounded=0;orthogonalLoop=1;jettySize=auto;"
    if relation == "inheritance":
        style += "endArrow=block;endFill=0;strokeColor=#333333;"
    elif relation == "composition":
        style += "endArrow=open;startArrow=diamond;startFill=1;strokeColor=#333333;"
    else:
        style += "endArrow=open;dashed=1;strokeColor=#666666;"

    label_attr = f' value="{html.escape(label)}"' if label else ""
    return f"""        <mxCell id="{eid}" edge="1" parent="1" source="{source}" target="{target}" style="{style}"{label_attr}>
          <mxGeometry relative="1" as="geometry" />
        </mxCell>"""


cells = [
    class_box("system_form", 550, 20, 250, 70, "Form", stereotype="System.Windows.Forms", fill="#f8f8f8"),
    class_box("chart", 1010, 410, 240, 70, "Chart", stereotype="DataVisualization", fill="#f8f8f8"),
    class_box("webview", 1010, 620, 240, 70, "WebView2", stereotype="Microsoft.Web.WebView2", fill="#f8f8f8"),

    class_box(
        "program",
        60,
        70,
        240,
        95,
        "Program",
        methods=["+ Main(): void"],
        stereotype="static",
        fill="#eaf3ff",
    ),
    class_box(
        "font_manager",
        60,
        250,
        310,
        145,
        "FontManager",
        attrs=["- privateFontCollection: PrivateFontCollection"],
        methods=[
            "+ LoadFontFromResource(resourceName): void",
            "+ GetFont(fontFamily, size, style): Font",
        ],
        stereotype="static",
        fill="#eaf3ff",
    ),
    class_box(
        "form1",
        420,
        150,
        260,
        135,
        "Form1",
        methods=[
            "+ Form1()",
            "- Form1_Load(sender, e): void",
            "- timer1_Tick(sender, e): void",
            "- parrotGradientPanel1_Paint(sender, e): void",
        ],
        fill="#fff7e6",
    ),
    class_box(
        "form2",
        740,
        150,
        300,
        150,
        "Form2",
        methods=[
            "+ Form2()",
            "- Form2_Load(sender, e): void",
            "- Form2_FormClosed(sender, e): void",
            "- foxButton1_Click ... foxButton9_Click: void",
        ],
        fill="#fff7e6",
    ),
    class_box(
        "option_choice",
        1090,
        160,
        250,
        85,
        "OptionChoice",
        attrs=["+ option: int = 1"],
        stereotype="static",
        fill="#eaf3ff",
    ),
    class_box(
        "panel_extensions",
        60,
        465,
        310,
        105,
        "PanelExtensions",
        methods=[
            "+ SetRoundedCorners(panel, radius): void",
            "- CreateRoundRectRgn(...): IntPtr",
        ],
        stereotype="static",
        fill="#eaf3ff",
    ),
    class_box(
        "form3",
        420,
        340,
        540,
        840,
        "Form3",
        attrs=[
            "- random: Random",
            "- chartArray: Chart",
            "- useChartVisualization: bool",
            "- isPaused: bool",
            "- stepMode: bool",
            "- pauseLock: object",
        ],
        methods=[
            "+ Form3()",
            "- FillCellsWithRandomNumbers(): void",
            "- SyncDataGridViewFromArray(array): void",
            "- SyncChartFromArray(array): void",
            "- SyncBothViews(array): void",
            "- GetArrayFromCells(): float[]",
            "- Swap(array, i, j): void",
            "- UpdateCellColor(columnIndex, color): void",
            "- UpdateCellValue(columnIndex, value): void",
            "- HasEmptyCells(): bool",
            "- BubbleSort(array, ascending): void",
            "- ShakerSort(array, ascending): void",
            "- SelectionSort(array, ascending): void",
            "- MergeSort(array, ascending): Task",
            "- MergeSortRecursive(array, left, right, ascending): Task",
            "- Merge(array, left, mid, right, ascending): Task",
            "- QuickSort(array, ascending): void",
            "- QuickSortRecursive(array, low, high, ascending): Task",
            "- PartitionWithMedianPivot(array, low, high, ascending): Task<int>",
            "- CombSort(array, ascending): void",
            "- LinearSearch(array, target): void",
            "- BinarySearch(array, target): void",
            "- JumpSearch(array, target): void",
            "- InitializeChart(): void",
            "- SwitchToGridView(): void",
            "- SwitchToChartView(): void",
            "- CenterChart(): void",
            "- UpdateChartCellColor(index, color): void",
            "- UpdateChartCellValue(index, value): void",
            "- UpdateDataGridViewSize(cellCount): void",
            "- UpdateChartSize(cellCount): void",
            "- CenterDataGridView(): void",
            "- ForceSyncBetweenViews(): void",
            "- SetControlsEnabled(enabled): void",
            "- WaitIfPaused(): Task",
            "- Log(message): void",
            "- Form3_Load(sender, e): void",
            "- Form3_Shown(sender, e): void",
            "- Form3_FormClosed(sender, e): void",
            "- CellCountTextBox_TextChanged(sender, e): void",
            "- dataGridView1_CellValidating(sender, e): void",
            "- dataGridView1_EditingControlShowing(sender, e): void",
            "- dataGridView1_CellEndEdit(sender, e): void",
            "- TextBox_KeyPress(sender, e): void",
            "- CellCountTextBox_KeyPress(sender, e): void",
            "- radioGridView_CheckedChanged(sender, e): void",
            "- radioChartView_CheckedChanged(sender, e): void",
            "- foxButton1_Click ... foxButton4_Click: void",
            "- playPictureBox_Click(sender, e): void",
            "- pausePictureBox_Click(sender, e): void",
            "- NextPictureBox_Click(sender, e): void",
            "- logButton_Click(sender, e): void",
            "- pictureBox1_Click(sender, e): void",
        ],
        fill="#fff7e6",
    ),
    class_box(
        "form4",
        1010,
        820,
        330,
        160,
        "Form4",
        attrs=[
            "- descriptionWeb: WebView2",
            "- exampleWeb: WebView2",
            "- exampleWeb2: WebView2",
        ],
        methods=[
            "+ Form4()",
            "- LoadAlgorithmData(): Task",
            "- Form4_Shown(sender, e): void",
            "- Form4_FormClosed(sender, e): void",
            "- pictureBox1_Click(sender, e): void",
        ],
        fill="#fff7e6",
    ),
]

edges = [
    edge("inh_form1", "form1", "system_form", relation="inheritance"),
    edge("inh_form2", "form2", "system_form", relation="inheritance"),
    edge("inh_form3", "form3", "system_form", relation="inheritance"),
    edge("inh_form4", "form4", "system_form", relation="inheritance"),
    edge("dep_program_form1", "program", "form1", "Application.Run()"),
    edge("dep_form1_form2", "form1", "form2", "переход после загрузки"),
    edge("dep_form2_form3", "form2", "form3", "выбор алгоритма"),
    edge("dep_form2_option", "form2", "option_choice", "записывает option"),
    edge("dep_form3_option", "form3", "option_choice", "читает option"),
    edge("dep_form4_option", "form4", "option_choice", "читает option"),
    edge("dep_form3_form2", "form3", "form2", "возврат"),
    edge("dep_form3_form4", "form3", "form4", "открывает справку"),
    edge("dep_form4_form3", "form4", "form3", "возврат из справки"),
    edge("dep_form3_panel", "form3", "panel_extensions", "скругляет панели"),
    edge("comp_form3_chart", "form3", "chart", "chartArray", relation="composition"),
    edge("comp_form4_webview", "form4", "webview", "3 компонента", relation="composition"),
]

xml = f"""<mxfile host="app.diagrams.net" modified="2026-06-17T00:00:00.000Z" agent="Codex" version="24.7.8">
  <diagram name="Диаграмма классов" id="class-diagram-diplom">
    <mxGraphModel dx="1420" dy="1200" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="1400" pageHeight="1250" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
{chr(10).join(cells)}
{chr(10).join(edges)}
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
"""

out = Path(__file__).parent / "class_diagram.drawio"
out.write_text(xml, encoding="utf-8")
print(f"Wrote {out}")
