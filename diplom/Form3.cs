using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TheArtOfDev.HtmlRenderer.Adapters;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace diplom
{
    public partial class Form3 : Form
    {

        private Random random = new Random();
        private Chart chartArray;
        private bool useChartVisualization = false;
        private bool isPaused = false;
        private bool stepMode = false;
        private object pauseLock = new object();


        private void FillCellsWithRandomNumbers()
        {
            if (dataGridView1 == null && !useChartVisualization) return;

            Log($"Заполнение массива ({CellCountTextBox.Text} элементов)");
            int filledCount = 0;

            int columnCount = useChartVisualization ?
                (chartArray.Series["ArrayValues"].Points.Count > 0 ?
                 chartArray.Series["ArrayValues"].Points.Count :
                 (dataGridView1?.ColumnCount ?? 10)) :
                dataGridView1.ColumnCount;

            float[] tempArray = new float[columnCount];

            for (int i = 0; i < columnCount; i++)
            {
                if (IntFloatChoice.SelectedIndex != 0)
                {
                    double minValue = double.Parse(MinRange.Text);
                    double maxValue = double.Parse(MaxRange.Text);
                    double value = random.NextDouble() * (maxValue - minValue) + minValue;
                    tempArray[i] = (float)value;
                }
                else
                {
                    int randomNumber = random.Next(int.Parse(MinRange.Text), int.Parse(MaxRange.Text));
                    tempArray[i] = randomNumber;
                }
            }

            SyncDataGridViewFromArray(tempArray);
            SyncChartFromArray(tempArray);

            Log($"Заполнено {columnCount} элементов");
        }

        private void SyncDataGridViewFromArray(float[] array)
        {
            if (dataGridView1 == null) return;


            if (dataGridView1.ColumnCount != array.Length)
            {
                UpdateDataGridViewSize(array.Length);
            }

            for (int i = 0; i < array.Length && i < dataGridView1.ColumnCount; i++)
            {
                string stringValue = IntFloatChoice.SelectedIndex != 0 ?
                    array[i].ToString("F2") :
                    ((int)array[i]).ToString();

                dataGridView1.Rows[0].Cells[i].Value = stringValue;
                dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
            }
            dataGridView1.ClearSelection();
        }

        private void SyncChartFromArray(float[] array)
        {
            if (chartArray == null) return;

            Series series = chartArray.Series["ArrayValues"];
            series.Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                string stringValue = IntFloatChoice.SelectedIndex != 0 ?
                    array[i].ToString("F2") :
                    ((int)array[i]).ToString();

                DataPoint point = new DataPoint(i, array[i]);
                point.Label = stringValue;
                point.Color = Color.FromArgb(65, 140, 240);
                point.AxisLabel = (i + 1).ToString();
                series.Points.Add(point);
            }


            chartArray.ChartAreas[0].AxisX.Minimum = -0.5;
            chartArray.ChartAreas[0].AxisX.Maximum = array.Length - 0.5;
            chartArray.ChartAreas[0].AxisX.Interval = 1;
            chartArray.ChartAreas[0].AxisX.LabelStyle.Format = "0";


            chartArray.ChartAreas[0].AxisX.CustomLabels.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                CustomLabel label = new CustomLabel
                {
                    FromPosition = i - 0.5,
                    ToPosition = i + 0.5,
                    Text = (i + 1).ToString(),
                    ForeColor = Color.White
                };
                chartArray.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }

            chartArray.Invalidate();
        }

        private void SyncBothViews(float[] array)
        {
            SyncDataGridViewFromArray(array);
            SyncChartFromArray(array);
        }

        private void Log(string message)
        {
            if (log != null && !string.IsNullOrEmpty(message))
            {
                if (log.InvokeRequired)
                {
                    log.Invoke(new Action(() => Log(message)));
                    return;
                }
                log.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            }
        }



        private float[] GetArrayFromCells()
        {
            int cellCount;
            float[] array;

            if (useChartVisualization && chartArray != null && chartArray.Series["ArrayValues"].Points.Count > 0)
            {

                cellCount = chartArray.Series["ArrayValues"].Points.Count;
                array = new float[cellCount];

                Log($"Чтение массива из диаграммы. Размер: {cellCount}");

                for (int i = 0; i < cellCount; i++)
                {
                    double value = chartArray.Series["ArrayValues"].Points[i].YValues[0];
                    array[i] = (float)value;
                    Log($"array[{i}] = {array[i]}");
                }
            }
            else
            {

                cellCount = dataGridView1.ColumnCount;
                array = new float[cellCount];

                Log($"Чтение массива из таблицы. Размер: {cellCount}");

                for (int i = 0; i < cellCount; i++)
                {
                    if (dataGridView1.Rows[0].Cells[i].Value != null &&
                        float.TryParse(dataGridView1.Rows[0].Cells[i].Value.ToString(), out float value))
                    {
                        array[i] = value;
                        Log($"array[{i}] = {value}");
                    }
                }
            }

            return array;
        }



        private void Swap(float[] array, int i, int j)
        {
            Log($"Обмен [{i}]<->[{j}]");
            float temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void UpdateCellColor(int columnIndex, Color color)
        {
            if (useChartVisualization)
            {
                UpdateChartCellColor(columnIndex, color);
            }
            else
            {
                dataGridView1.Rows[0].Cells[columnIndex].Style.BackColor = color;
            }
        }

        private void UpdateCellValue(int columnIndex, string value)
        {
            if (useChartVisualization)
            {
                UpdateChartCellValue(columnIndex, value);
            }
            else
            {
                dataGridView1.Rows[0].Cells[columnIndex].Value = value;
            }
        }

        private bool HasEmptyCells()
        {
            if (dataGridView1 == null) return true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        Log($"Обнаружена пустая ячейка [{row.Index},{cell.ColumnIndex}]");
                        return true;
                    }
                }
            }
            Log("Проверка на пустые ячейки пройдена успешно");
            return false;
        }








        private async void LinearSearch(float[] array, float target)
        {
            Log($"=== ЛИНЕЙНЫЙ ПОИСК {target} ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                await WaitIfPaused();

                UpdateCellColor(i, Color.Red);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                if (array[i] == target)
                {
                    Log($"Найден на позиции {i}");
                    UpdateCellColor(i, Color.Green);
                    found = true;
                    MessageBox.Show($"Элемент {target} найден на позиции {i}", "Результат поиска");
                    break;
                }
                else
                {
                    UpdateCellColor(i, Color.LightGray);
                }
            }

            if (!found)
            {
                Log($"Элемент {target} не найден");
                MessageBox.Show($"Элемент {target} не найден", "Результат поиска");
            }

            await Task.Delay(1000);
            for (int i = 0; i < array.Length; i++)
            {
                UpdateCellColor(i, Color.LightBlue);
            }

            Log("=== ПОИСК ЗАВЕРШЕН ===");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }





        private async void BinarySearch(float[] array, float target)
        {
            bool ascending = DirectionComboBox.SelectedIndex == 0;
            Log($"=== БИНАРНЫЙ ПОИСК {target} ({(ascending ? "возр" : "убыв")}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            int left = 0;
            int right = array.Length - 1;
            bool found = false;
            int steps = 0;

            while (left <= right)
            {
                await WaitIfPaused();

                steps++;
                int mid = left + (right - left) / 2;

                UpdateCellColor(mid, Color.Red);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                if (array[mid] == target)
                {
                    Log($"Найден на позиции {mid} за {steps} шагов");
                    UpdateCellColor(mid, Color.Green);
                    found = true;
                    MessageBox.Show($"Элемент {target} найден на позиции {mid}", "Результат поиска");
                    break;
                }
                else if ((ascending && array[mid] < target) || (!ascending && array[mid] > target))
                {
                    for (int i = left; i <= mid; i++) UpdateCellColor(i, Color.LightGray);
                    left = mid + 1;
                }
                else
                {
                    for (int i = mid; i <= right; i++) UpdateCellColor(i, Color.LightGray);
                    right = mid - 1;
                }

                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();
            }

            if (!found)
            {
                Log($"Элемент {target} не найден за {steps} шагов");
                MessageBox.Show($"Элемент {target} не найден", "Результат поиска");
            }

            await Task.Delay(1000);
            for (int i = 0; i < array.Length; i++) UpdateCellColor(i, Color.LightBlue);

            Log("=== ПОИСК ЗАВЕРШЕН ===");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }






        private async void JumpSearch(float[] array, float target)
        {
            bool ascending = DirectionComboBox.SelectedIndex == 0;
            Log($"=== ПОИСК ПРЫЖКАМИ {target} ({(ascending ? "возр" : "убыв")}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            int n = array.Length;
            int step = (int)Math.Sqrt(n);
            int prev = 0;
            bool found = false;
            int steps = 0;

            while ((ascending && prev < n && array[Math.Min(step, n) - 1] < target) ||
                   (!ascending && prev < n && array[Math.Min(step, n) - 1] > target))
            {
                await WaitIfPaused();
                steps++;

                for (int i = prev; i < Math.Min(step, n); i++) UpdateCellColor(i, Color.Yellow);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                prev = step;
                step += (int)Math.Sqrt(n);

                if (prev >= n) break;
            }

            if (ascending)
            {
                for (int i = prev; i < Math.Min(step, n); i++)
                {
                    await WaitIfPaused();
                    steps++;

                    UpdateCellColor(i, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    if (array[i] == target)
                    {
                        Log($"Найден на позиции {i} за {steps} шагов");
                        UpdateCellColor(i, Color.Green);
                        found = true;
                        MessageBox.Show($"Элемент {target} найден на позиции {i}", "Результат поиска");
                        break;
                    }
                    else if (array[i] > target) break;
                    else UpdateCellColor(i, Color.LightGray);
                }
            }
            else
            {
                for (int i = Math.Min(step, n) - 1; i >= prev; i--)
                {
                    await WaitIfPaused();
                    steps++;

                    UpdateCellColor(i, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    if (array[i] == target)
                    {
                        Log($"Найден на позиции {i} за {steps} шагов");
                        UpdateCellColor(i, Color.Green);
                        found = true;
                        MessageBox.Show($"Элемент {target} найден на позиции {i}", "Результат поиска");
                        break;
                    }
                    else if (array[i] < target) break;
                    else UpdateCellColor(i, Color.LightGray);
                }
            }

            if (!found)
            {
                Log($"Элемент {target} не найден за {steps} шагов");
                MessageBox.Show($"Элемент {target} не найден", "Результат поиска");
            }

            await Task.Delay(1000);
            for (int i = 0; i < array.Length; i++) UpdateCellColor(i, Color.LightBlue);

            Log("=== ПОИСК ЗАВЕРШЕН ===");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }









        private async void BubbleSort(float[] array, bool ascending = true)
        {
            string order = ascending ? "возр" : "убыв";
            Log($"=== ПУЗЫРЕК ({order}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            int n = array.Length;
            int swaps = 0;
            int comparisons = 0;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    await WaitIfPaused();
                    comparisons++;

                    UpdateCellColor(j, Color.Red);
                    UpdateCellColor(j + 1, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    bool shouldSwap = ascending ? array[j] > array[j + 1] : array[j] < array[j + 1];

                    if (shouldSwap)
                    {
                        swaps++;
                        Log($"Обмен {swaps}: [{j}]<->[{j + 1}]");

                        UpdateCellColor(j, Color.Orange);
                        UpdateCellColor(j + 1, Color.Orange);
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();

                        Swap(array, j, j + 1);
                        UpdateCellValue(j, array[j].ToString());
                        UpdateCellValue(j + 1, array[j + 1].ToString());

                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }

                    UpdateCellColor(j, Color.LightBlue);
                    UpdateCellColor(j + 1, Color.LightBlue);
                }

                UpdateCellColor(n - i - 1, Color.Green);
            }

            UpdateCellColor(0, Color.Green);
            Log($"Сортировка завершена. Сравнений: {comparisons}, Обменов: {swaps}");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }









        private async void ShakerSort(float[] array, bool ascending = true)
        {
            string order = ascending ? "возр" : "убыв";
            Log($"=== ШЕЙКЕРНАЯ ({order}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            int n = array.Length;
            int left = 0;
            int right = n - 1;
            int swaps = 0;
            int passes = 0;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            while (left <= right)
            {
                await WaitIfPaused();
                passes++;

                // Прямой проход
                for (int i = left; i < right; i++)
                {
                    await WaitIfPaused();

                    UpdateCellColor(i, Color.Red);
                    UpdateCellColor(i + 1, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    bool shouldSwap = ascending ? array[i] > array[i + 1] : array[i] < array[i + 1];

                    if (shouldSwap)
                    {
                        swaps++;
                        Swap(array, i, i + 1);
                        UpdateCellValue(i, array[i].ToString());
                        UpdateCellValue(i + 1, array[i + 1].ToString());
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }

                    UpdateCellColor(i, Color.LightBlue);
                    UpdateCellColor(i + 1, Color.LightBlue);
                }
                UpdateCellColor(right, Color.Green);
                right--;

                if (left > right) break;

                // Обратный проход
                for (int i = right; i > left; i--)
                {
                    await WaitIfPaused();

                    UpdateCellColor(i, Color.Red);
                    UpdateCellColor(i - 1, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    bool shouldSwap = ascending ? array[i - 1] > array[i] : array[i - 1] < array[i];

                    if (shouldSwap)
                    {
                        swaps++;
                        Swap(array, i - 1, i);
                        UpdateCellValue(i - 1, array[i - 1].ToString());
                        UpdateCellValue(i, array[i].ToString());
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }

                    UpdateCellColor(i, Color.LightBlue);
                    UpdateCellColor(i - 1, Color.LightBlue);
                }
                UpdateCellColor(left, Color.Green);
                left++;
            }

            for (int i = 0; i < n; i++) UpdateCellColor(i, Color.Green);
            Log($"Завершено. Проходов: {passes}, Обменов: {swaps}");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;
            findbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }









        private async void SelectionSort(float[] array, bool ascending = true)
        {
            string order = ascending ? "возр" : "убыв";
            Log($"=== ВЫБОР ({order}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            int n = array.Length;
            int swaps = 0;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            for (int i = 0; i < n - 1; i++)
            {
                await WaitIfPaused();

                int extremeIndex = i;
                UpdateCellColor(extremeIndex, Color.Orange);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                for (int j = i + 1; j < n; j++)
                {
                    await WaitIfPaused();

                    UpdateCellColor(j, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    bool shouldUpdateExtreme = ascending ? array[j] < array[extremeIndex] : array[j] > array[extremeIndex];

                    if (shouldUpdateExtreme)
                    {
                        UpdateCellColor(extremeIndex, Color.LightBlue);
                        extremeIndex = j;
                        UpdateCellColor(extremeIndex, Color.Orange);
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }
                    else
                    {
                        UpdateCellColor(j, Color.LightBlue);
                    }
                }

                if (extremeIndex != i)
                {
                    swaps++;
                    UpdateCellColor(i, Color.Orange);
                    UpdateCellColor(extremeIndex, Color.Orange);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    Swap(array, i, extremeIndex);
                    UpdateCellValue(i, array[i].ToString());
                    UpdateCellValue(extremeIndex, array[extremeIndex].ToString());
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();
                }

                UpdateCellColor(i, Color.Green);
            }

            UpdateCellColor(n - 1, Color.Green);
            Log($"Завершено. Обменов: {swaps}");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }









        private async Task MergeSort(float[] array, bool ascending = true)
        {
            string order = ascending ? "возр" : "убыв";
            Log($"=== СЛИЯНИЕ ({order}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            await MergeSortRecursive(array, 0, array.Length - 1, ascending);

            for (int i = 0; i < array.Length; i++)
            {
                UpdateCellColor(i, Color.Green);
                await Task.Delay(50);
            }

            Log("=== СОРТИРОВКА ЗАВЕРШЕНА ===");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }






        private async Task MergeSortRecursive(float[] array, int left, int right, bool ascending)
        {
            if (left < right)
            {
                await WaitIfPaused();

                int mid = left + (right - left) / 2;

                for (int i = left; i <= right; i++) UpdateCellColor(i, Color.Purple);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                await MergeSortRecursive(array, left, mid, ascending);
                await MergeSortRecursive(array, mid + 1, right, ascending);
                await Merge(array, left, mid, right, ascending);
            }
        }


        private async Task Merge(float[] array, int left, int mid, int right, bool ascending)
        {
            await WaitIfPaused();

            int n1 = mid - left + 1;
            int n2 = right - mid;

            float[] leftArray = new float[n1];
            float[] rightArray = new float[n2];

            for (int x = 0; x < n1; x++) leftArray[x] = array[left + x];
            for (int y = 0; y < n2; y++) rightArray[y] = array[mid + 1 + y];

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                await WaitIfPaused();

                UpdateCellColor(left + i, Color.Red);
                UpdateCellColor(mid + 1 + j, Color.Red);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                bool condition = ascending ? leftArray[i] <= rightArray[j] : leftArray[i] >= rightArray[j];

                if (condition)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }

                UpdateCellColor(k, Color.Orange);
                UpdateCellValue(k, array[k].ToString());
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();
                UpdateCellColor(k, Color.LightBlue);
                k++;
            }

            while (i < n1)
            {
                await WaitIfPaused();
                array[k] = leftArray[i];
                UpdateCellColor(k, Color.Orange);
                UpdateCellValue(k, array[k].ToString());
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();
                UpdateCellColor(k, Color.LightBlue);
                i++;
                k++;
            }

            while (j < n2)
            {
                await WaitIfPaused();
                array[k] = rightArray[j];
                UpdateCellColor(k, Color.Orange);
                UpdateCellValue(k, array[k].ToString());
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();
                UpdateCellColor(k, Color.LightBlue);
                j++;
                k++;
            }

            for (int x = left; x <= right; x++) UpdateCellColor(x, Color.Green);
            await Task.Delay(delayTrackBar.Value);
            await WaitIfPaused();
        }




        //private async void MergeSortWrapper(float[] array, bool ascending = true)
        //{
        //    await MergeSort(array, ascending);
        //}

        private async void QuickSort(float[] array, bool ascending = true)
        {
            string order = ascending ? "возр" : "убыв";
            Log($"=== БЫСТРАЯ ({order}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;
            clearbutton.Enabled = false;

            await QuickSortRecursive(array, 0, array.Length - 1, ascending);

            for (int i = 0; i < array.Length; i++)
            {
                UpdateCellColor(i, Color.Green);
                await Task.Delay(50);
            }

            Log("=== СОРТИРОВКА ЗАВЕРШЕНА ===");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;
            clearbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }

        private async Task QuickSortRecursive(float[] array, int low, int high, bool ascending)
        {
            if (low < high)
            {
                await WaitIfPaused();

                for (int i = low; i <= high; i++) UpdateCellColor(i, Color.Purple);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                int pivotIndex = await PartitionWithMedianPivot(array, low, high, ascending);
                UpdateCellColor(pivotIndex, Color.Green);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                await QuickSortRecursive(array, low, pivotIndex - 1, ascending);
                await QuickSortRecursive(array, pivotIndex + 1, high, ascending);
            }
            else if (low == high)
            {
                UpdateCellColor(low, Color.Green);
                await Task.Delay(delayTrackBar.Value);
            }
        }

        private async Task<int> PartitionWithMedianPivot(float[] array, int low, int high, bool ascending)
        {
            await WaitIfPaused();

            int mid = low + (high - low) / 2;

            if (ascending)
            {
                if ((array[low] <= array[mid] && array[mid] <= array[high]) ||
                    (array[high] <= array[mid] && array[mid] <= array[low]))
                {
                    if (mid != high)
                    {
                        UpdateCellColor(mid, Color.Orange);
                        UpdateCellColor(high, Color.Orange);
                        Swap(array, mid, high);
                        UpdateCellValue(mid, array[mid].ToString());
                        UpdateCellValue(high, array[high].ToString());
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }
                }
                else if ((array[mid] <= array[low] && array[low] <= array[high]) ||
                         (array[high] <= array[low] && array[low] <= array[mid]))
                {
                    if (low != high)
                    {
                        UpdateCellColor(low, Color.Orange);
                        UpdateCellColor(high, Color.Orange);
                        Swap(array, low, high);
                        UpdateCellValue(low, array[low].ToString());
                        UpdateCellValue(high, array[high].ToString());
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }
                }
            }

            float pivot = array[high];
            UpdateCellColor(high, Color.Purple);
            await Task.Delay(delayTrackBar.Value);
            await WaitIfPaused();

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                await WaitIfPaused();

                UpdateCellColor(j, Color.Red);
                if (i >= low) UpdateCellColor(i, Color.Orange);
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();

                bool shouldSwap = ascending ? array[j] <= pivot : array[j] >= pivot;

                if (shouldSwap)
                {
                    i++;
                    UpdateCellColor(i, Color.Orange);
                    UpdateCellColor(j, Color.Orange);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    if (i != j)
                    {
                        Swap(array, i, j);
                        UpdateCellValue(i, array[i].ToString());
                        UpdateCellValue(j, array[j].ToString());
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }
                }

                UpdateCellColor(j, Color.LightBlue);
                if (i >= low) UpdateCellColor(i, Color.LightBlue);
            }

            if (i + 1 != high)
            {
                UpdateCellColor(i + 1, Color.Orange);
                UpdateCellColor(high, Color.Orange);
                Swap(array, i + 1, high);
                UpdateCellValue(i + 1, array[i + 1].ToString());
                UpdateCellValue(high, array[high].ToString());
                await Task.Delay(delayTrackBar.Value);
                await WaitIfPaused();
            }

            for (int j = low; j <= high; j++)
            {
                if (j != i + 1) UpdateCellColor(j, Color.LightBlue);
            }

            return i + 1;
        }


        private async void CombSort(float[] array, bool ascending = true)
        {
            string order = ascending ? "возр" : "убыв";
            Log($"=== РАСЧЕСКА ({order}) ===");

            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;

            int n = array.Length;
            int gap = n;
            bool swapped = true;
            int swaps = 0;

            sortbutton.Enabled = false;
            fillbutton.Enabled = false;

            while (gap > 1 || swapped)
            {
                await WaitIfPaused();

                gap = Math.Max(1, (int)(gap / 1.3));
                swapped = false;

                for (int i = 0; i + gap < n; i++)
                {
                    await WaitIfPaused();

                    UpdateCellColor(i, Color.Red);
                    UpdateCellColor(i + gap, Color.Red);
                    await Task.Delay(delayTrackBar.Value);
                    await WaitIfPaused();

                    bool shouldSwap = ascending ? array[i] > array[i + gap] : array[i] < array[i + gap];

                    if (shouldSwap)
                    {
                        swaps++;
                        Swap(array, i, i + gap);
                        swapped = true;
                        UpdateCellValue(i, array[i].ToString());
                        UpdateCellValue(i + gap, array[i + gap].ToString());
                        await Task.Delay(delayTrackBar.Value);
                        await WaitIfPaused();
                    }

                    UpdateCellColor(i, Color.LightBlue);
                    UpdateCellColor(i + gap, Color.LightBlue);
                }
            }

            for (int i = 0; i < n; i++)
            {
                UpdateCellColor(i, Color.Green);
                await Task.Delay(50);
            }

            Log($"Завершено. Обменов: {swaps}");

            sortbutton.Enabled = true;
            fillbutton.Enabled = true;

            isPaused = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }

        public Form3()
        {
            InitializeComponent();

            InitializeChart();
            UpdateDataGridViewSize(10);
            nightPanel1.SetRoundedCorners(25);
            nightPanel3.SetRoundedCorners(25);
            nightPanel4.SetRoundedCorners(25);
            nightPanel5.SetRoundedCorners(25);
            Log($"Выбран алгоритм: {(OptionChoice.option <= 6 ? "Сортировка" : "Поиск")}");

        }



        private void InitializeChart()
        {
            chartArray = new Chart
            {
                Name = "chartArray",
                Visible = false,
                Dock = DockStyle.None,
                Size = new Size(800, 300),
                BackColor = Color.FromArgb(30, 30, 35),
                Location = new Point(0, 0)
            };


            ChartArea chartArea = new ChartArea
            {
                Name = "MainArea",
                BackColor = Color.FromArgb(40, 40, 45),
                AxisX = new Axis
                {
                    Title = "Индекс",
                    TitleForeColor = Color.White,
                    LabelStyle = new LabelStyle
                    {
                        ForeColor = Color.White,
                        Format = "0",
                        Interval = 1
                    },
                    MajorGrid = new Grid { LineColor = Color.FromArgb(60, 60, 65) },
                    MajorTickMark = new TickMark { Interval = 1 },
                    Minimum = 0,
                    Maximum = 10,
                    Interval = 1
                },
                AxisY = new Axis
                {
                    Title = "Значение",
                    TitleForeColor = Color.White,
                    LabelStyle = new LabelStyle { ForeColor = Color.White },
                    MajorGrid = new Grid { LineColor = Color.FromArgb(60, 60, 65) }
                }
            };
            chartArray.ChartAreas.Add(chartArea);

            // Настройка серии (столбцы)
            Series series = new Series
            {
                Name = "ArrayValues",
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(65, 140, 240),
                BorderWidth = 2,
                ShadowOffset = 2,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            chartArray.Series.Add(series);

            if (panel3 != null)
            {
                panel3.Controls.Add(chartArray);
                chartArray.BringToFront();
            }
            else
            {
                this.Controls.Add(chartArray);
            }
        }

        private void SwitchToGridView()
        {
            if (dataGridView1 == null) return;


            if (chartArray != null && chartArray.Series["ArrayValues"].Points.Count > 0)
            {
                float[] arrayFromChart = new float[chartArray.Series["ArrayValues"].Points.Count];
                for (int i = 0; i < arrayFromChart.Length; i++)
                {
                    arrayFromChart[i] = (float)chartArray.Series["ArrayValues"].Points[i].YValues[0];
                }


                if (dataGridView1.ColumnCount != arrayFromChart.Length)
                {
                    UpdateDataGridViewSize(arrayFromChart.Length);
                }

                // Синхронизируем данные
                SyncDataGridViewFromArray(arrayFromChart);

            }

            dataGridView1.Visible = true;
            if (chartArray != null)
            {
                chartArray.Visible = false;
            }

            CenterDataGridView();
        }

        private void SwitchToChartView()
        {
            if (dataGridView1 == null || chartArray == null) return;


            bool hasData = false;
            float[] arrayFromGrid = new float[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Rows[0].Cells[i].Value != null &&
                    float.TryParse(dataGridView1.Rows[0].Cells[i].Value.ToString(), out float value))
                {
                    arrayFromGrid[i] = value;
                    hasData = true;
                }
            }

            if (hasData)
            {

                if (chartArray.Series["ArrayValues"].Points.Count != dataGridView1.ColumnCount)
                {
                    UpdateChartSize(dataGridView1.ColumnCount);
                }


                SyncChartFromArray(arrayFromGrid);

            }

            dataGridView1.Visible = false;
            chartArray.Visible = true;
            CenterChart();
        }

        private void CenterChart()
        {
            if (chartArray.Parent != null && chartArray.Visible && panel3 != null)
            {
                // Центрируем относительно panel3
                int parentWidth = panel3.ClientSize.Width;
                int left = (parentWidth - chartArray.Width) / 2;

                // Позиционируем внутри panel3
                chartArray.Location = new Point(left, 60);
            }
        }

        //private void UpdateChartFromArray()
        //{
        //    if (!useChartVisualization || chartArray == null) return;

        //    float[] array = GetArrayFromCells();
        //    Series series = chartArray.Series["ArrayValues"];
        //    series.Points.Clear();

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        DataPoint point = new DataPoint(i, array[i]);
        //        string stringValue = IntFloatChoice.SelectedIndex != 0 ?
        //            array[i].ToString("F2") :
        //            ((int)array[i]).ToString();
        //        point.Label = stringValue;
        //        point.Color = Color.FromArgb(65, 140, 240);
        //        series.Points.Add(point);
        //    }

        //    // Настройка осей
        //    chartArray.ChartAreas[0].AxisX.Minimum = -0.5;
        //    chartArray.ChartAreas[0].AxisX.Maximum = array.Length - 0.5;
        //    chartArray.ChartAreas[0].AxisX.Interval = 1;
        //    chartArray.Invalidate();
        //}

        private void UpdateChartCellColor(int index, Color color)
        {
            if (!useChartVisualization || chartArray == null) return;

            if (index >= 0 && index < chartArray.Series["ArrayValues"].Points.Count)
            {
                chartArray.Series["ArrayValues"].Points[index].Color = color;
                chartArray.Invalidate();
            }
        }

        private void UpdateChartCellValue(int index, string value)
        {
            if (!useChartVisualization || chartArray == null) return;

            if (index >= 0 && index < chartArray.Series["ArrayValues"].Points.Count)
            {
                if (float.TryParse(value, out float floatValue))
                {
                    chartArray.Series["ArrayValues"].Points[index].YValues[0] = floatValue;
                    chartArray.Series["ArrayValues"].Points[index].Label = value;
                    chartArray.Invalidate();
                }
            }
        }

        //private void ResetChartColors()
        //{
        //    if (!useChartVisualization || chartArray == null) return;

        //    foreach (var point in chartArray.Series["ArrayValues"].Points)
        //    {
        //        point.Color = Color.FromArgb(65, 140, 240);
        //    }
        //    chartArray.Invalidate();
        //}




        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            isPaused = true;
            Form2 form2 = new Form2();
            form2.Show();
            nightPanel2.Visible = false;
        }

        private void CellCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CellCountTextBox.Text) || !int.TryParse(CellCountTextBox.Text, out int cellCount) || cellCount < 2 || cellCount > 20)
            {
                return;
            }


            bool wasChartMode = useChartVisualization;


            if (useChartVisualization)
            {
                UpdateChartSize(cellCount);
            }
            else
            {
                UpdateDataGridViewSize(cellCount);
            }
        }

        private void UpdateDataGridViewSize(int cellCount)
        {
            if (dataGridView1 == null) return;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < cellCount; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Width = 55,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        BackColor = Color.LightGray,
                        SelectionBackColor = Color.LightGray,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Padding = new Padding(0)
                    }
                });
            }

            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Height = 55;


            if (chartArray != null && chartArray.Series["ArrayValues"].Points.Count == cellCount)
            {
                bool hasData = false;
                for (int i = 0; i < cellCount; i++)
                {
                    if (chartArray.Series["ArrayValues"].Points[i].YValues[0] != 0)
                    {
                        hasData = true;
                        break;
                    }
                }

                if (hasData)
                {
                    for (int i = 0; i < cellCount; i++)
                    {
                        double value = chartArray.Series["ArrayValues"].Points[i].YValues[0];
                        string stringValue = IntFloatChoice.SelectedIndex != 0 ?
                            value.ToString("F2") :
                            ((int)value).ToString();
                        dataGridView1.Rows[0].Cells[i].Value = stringValue;
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                    }
                }
                else
                {

                    for (int i = 0; i < cellCount; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = "";
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                    }
                }
            }
            else
            {

                for (int i = 0; i < cellCount; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = "";
                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                }
            }

            int totalWidth = cellCount * 55 + 2;
            dataGridView1.Size = new Size(totalWidth, 57);

            CenterDataGridView();

            // Синхронизируем диаграмму
            if (chartArray != null)
            {
                UpdateChartSize(cellCount);
            }
        }

        private void UpdateChartSize(int cellCount)
        {
            if (chartArray == null) return;

            Series series = chartArray.Series["ArrayValues"];

            // 
            float[] oldValues = new float[series.Points.Count];
            for (int i = 0; i < series.Points.Count && i < oldValues.Length; i++)
            {
                oldValues[i] = (float)series.Points[i].YValues[0];
            }

            series.Points.Clear();


            for (int i = 0; i < cellCount; i++)
            {
                float value = (i < oldValues.Length) ? oldValues[i] : 0;
                string stringValue = IntFloatChoice.SelectedIndex != 0 ?
                    value.ToString("F2") :
                    ((int)value).ToString();

                DataPoint point = new DataPoint(i, value);
                point.Label = (value == 0 && i >= oldValues.Length) ? "0" : stringValue;
                point.Color = Color.FromArgb(65, 140, 240);
                point.AxisLabel = (i + 1).ToString();
                series.Points.Add(point);
            }


            chartArray.ChartAreas[0].AxisX.Minimum = -0.5;
            chartArray.ChartAreas[0].AxisX.Maximum = cellCount - 0.5;
            chartArray.ChartAreas[0].AxisX.Interval = 1;


            chartArray.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            chartArray.ChartAreas[0].AxisX.CustomLabels.Clear();


            for (int i = 0; i < cellCount; i++)
            {
                CustomLabel label = new CustomLabel
                {
                    FromPosition = i - 0.5,
                    ToPosition = i + 0.5,
                    Text = (i + 1).ToString(),
                    ForeColor = Color.White
                };
                chartArray.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }


            int totalWidth = cellCount * 55 + 100;
            chartArray.Size = new Size(Math.Min(totalWidth, panel3?.Width - 50 ?? this.Width - 50), 300);

            CenterChart();
            chartArray.Invalidate();

            Log($"Размер диаграммы изменен на {cellCount} элементов");
        }

        private void CenterDataGridView()
        {
            if (dataGridView1.Parent != null)
            {
                int parentWidth = dataGridView1.Parent.ClientSize.Width;
                int left = (parentWidth - dataGridView1.Width) / 2;

                int top = dataGridView1.Top;

                dataGridView1.Location = new Point(left, top);
            }
        }

        private void CellCountTextBox_Click(object sender, EventArgs e)
        {

        }

        //private void airButton1_Click(object sender, EventArgs e)
        //{
        //    Log("Пользователь инициировал заполнение таблицы случайными числами");
        //    FillCellsWithRandomNumbers();
        //}

        //private void airButton2_Click(object sender, EventArgs e)
        //{
        //    float[] array = GetArrayFromCells();
        //    BubbleSort(array);
        //}

        private void x(object sender, EventArgs e)
        {
            dungeonLabel1.Text = $"Задержка: {delayTrackBar.Value} мс";
        }

        private void metroTrackBar1_TextChanged(object sender, EventArgs e)
        {
            dungeonLabel1.Text = $"Задержка: {delayTrackBar.Value} мс";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            dungeonLabel1.Text = $"Задержка: {delayTrackBar.Value} мс";
        }

        private void foxButton2_Click(object sender, EventArgs e)
        {
            FillCellsWithRandomNumbers();
        }

        private void foxButton1_Click(object sender, EventArgs e)
        {

            if (HasEmptyCells())
            {
                MessageBox.Show("Ошибка! В таблице есть пустые ячейки!");
            }
            else
            {
                float[] array = GetArrayFromCells();

                bool ascending = DirectionComboBox.SelectedIndex == 0;
                int choice = OptionChoice.option;

                Log($"Запуск алгоритма с порядком: {(ascending ? "по возрастанию" : "по убыванию")}");

                switch (choice)
                {
                    case 1:
                        Log("Выполняется сортировка пузырьком");
                        BubbleSort(array, ascending);
                        break;
                    case 2:
                        Log("Выполняется сортировка перемешиванием (Shaker Sort)");
                        ShakerSort(array, ascending);
                        break;
                    case 3:
                        Log("Выполняется сортировка расческой (Comb Sort)");
                        CombSort(array, ascending);
                        break;
                    case 4:
                        Log("Выполняется сортировка выбором");
                        SelectionSort(array, ascending);
                        break;
                    case 5:
                        Log("Выполняется быстрая сортировка (Quick Sort)");
                        QuickSort(array, ascending);
                        break;
                    case 6:
                        Log("Выполняется сортировка слиянием (Merge Sort)");
                        MergeSort(array, ascending);
                        break;
                    case 7:
                        Log("Выполняется сортировка перемешиванием (Shaker Sort)");
                        ShakerSort(array, ascending);
                        break;
                    case 8:
                        Log("Выполняется сортировка перемешиванием (Shaker Sort)");
                        ShakerSort(array, ascending);
                        break;
                    case 9:
                        Log("Выполняется сортировка перемешиванием (Shaker Sort)");
                        ShakerSort(array, ascending);
                        break;
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //////////////////////////////////////////
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is System.Windows.Forms.TextBox textBox)
            {
                textBox.KeyPress -= TextBox_KeyPress;

                textBox.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '-' && MinRange.Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MinRange.Text, out int value1) && int.TryParse(MaxRange.Text, out int value2))
            {
                if (value1 > value2)
                {

                    MinRange.Undo();
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '-' && MaxRange.Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void foxButton3_Click(object sender, EventArgs e)
        {
            if (isPaused == true)
            {
                isPaused = false;
                pausePictureBox.Visible = true;
                playPictureBox.Visible = false;
            }

            Log("Очистка таблицы и диаграммы");

            int currentSize = 10; // Значение по умолчанию

            if (dataGridView1 != null)
            {
                currentSize = dataGridView1.ColumnCount;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Value = string.Empty;
                        cell.Style.BackColor = Color.White;
                    }
                }
                Log("Таблица очищена");
            }

            if (chartArray != null && chartArray.Series.IndexOf("ArrayValues") != -1)
            {

                for (int i = 0; i < chartArray.Series["ArrayValues"].Points.Count; i++)
                {
                    chartArray.Series["ArrayValues"].Points[i].YValues[0] = 0;
                    chartArray.Series["ArrayValues"].Points[i].Label = "0";
                    chartArray.Series["ArrayValues"].Points[i].Color = Color.FromArgb(65, 140, 240);
                }
                chartArray.Invalidate();
                Log("Диаграмма очищена");
            }


            if (useChartVisualization && chartArray != null && chartArray.Series["ArrayValues"].Points.Count == 0)
            {
                UpdateChartSize(currentSize);
            }

            Log("Очистка завершена");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = true;

            if (int.TryParse(MinRange.Text, out int value1) && int.TryParse(MaxRange.Text, out int value2))
            {
                if (value1 >= value2)
                {
                    errorProvider1.SetError(MaxRange, "Максимальное значение должно быть больше минимального");
                    e.Cancel = true;
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(MaxRange, "");
                }
            }
            else
            {
                errorProvider1.SetError(MaxRange, "Введите корректные числа");
                e.Cancel = true;
                isValid = false;
            }


            SetControlsEnabled(isValid);
        }

        private void SetControlsEnabled(bool enabled)
        {

            Control[] controlsToDisable = { sortbutton, fillbutton, clearbutton,
                                  IntFloatChoice, dataGridView1};

            foreach (Control control in controlsToDisable)
            {
                control.Enabled = enabled;
            }


            MinRange.Enabled = true;
            MaxRange.Enabled = true;
        }

        private void dungeonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialSlider1_RightToLeftChanged(object sender, EventArgs e)
        {
            dungeonLabel1.Text = $"Задержка: {delayTrackBar.Value} мс";
        }

        private void foxButton4_Click(object sender, EventArgs e)
        {
            int choice = OptionChoice.option;
            float target = float.Parse(textBox3.Text);
            float[] array = GetArrayFromCells();

            Log($"Поиск элемента {target} в массиве");

            switch (choice)
            {
                case 7:
                    Log("Выполняется линейный поиск");
                    LinearSearch(array, target);
                    break;
                case 8:
                    Log("Выполняется бинарный поиск");
                    BinarySearch(array, target);
                    break;
                case 9:
                    Log("Выполняется поиск прыжками");
                    JumpSearch(array, target);
                    break;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                ((System.Windows.Forms.TextBox)sender).Text.IndexOfAny(new char[] { '.', ',' }) > -1)
            {
                e.Handled = true;
            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            if (OptionChoice.option > 6)
            {
                nightPanel2.Visible = true;
                if (OptionChoice.option > 7)
                    findbutton.Enabled = false;
            }

            switch (OptionChoice.option)
            {
                case 1:
                    nameLabel.Text = "Сортировка пузырьком";
                    break;
                case 2:
                    nameLabel.Text = "Шейкерная сортировка";
                    break;
                case 3:
                    nameLabel.Text = "Сортировка расчёской";
                    break;
                case 4:
                    nameLabel.Text = "Сортировка выбором";
                    break;
                case 5:
                    nameLabel.Text = "Быстрая сортировка";
                    break;
                case 6:
                    nameLabel.Text = "Сортировка слиянием";
                    break;
                case 7:
                    nameLabel.Text = "Линейный поиск";
                    break;
                case 8:
                    nameLabel.Text = "Бинарный поиск";
                    break;
                case 9:
                    nameLabel.Text = "Поиск прыжками";
                    break;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = false;


            if (useChartVisualization && chartArray != null && e.RowIndex == 0)
            {
                float[] updatedArray = GetArrayFromCells();
                SyncChartFromArray(updatedArray);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void codeRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bigLabel9_Click(object sender, EventArgs e)
        {

        }

        private void log_TextChanged(object sender)
        {

        }

        private void CellCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void radioGridView_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGridView.Checked && useChartVisualization != false)
            {

                useChartVisualization = false;
                SwitchToGridView();
            }
        }

        private void radioChartView_CheckedChanged(object sender, EventArgs e)
        {
            if (radioChartView.Checked)
            {
                useChartVisualization = true;
                SwitchToChartView();
            }
        }

        private void MaxRange_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MaxRange, "Максимальное значение диапазона чисел для заполнения");
        }

        private void MinRange_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MinRange, "Минимальное значение диапазона чисел для заполнения");
        }

        private void bigLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task WaitIfPaused()
        {
            while (isPaused)
            {
                if (stepMode)
                {
                    stepMode = false;
                    return;
                }
                await Task.Delay(50);
            }
        }
        

        private void ForceSyncBetweenViews()
        {
            if (dataGridView1 == null || chartArray == null) return;

            float[] currentData;


            if (useChartVisualization && chartArray.Visible && chartArray.Series["ArrayValues"].Points.Count > 0)
            {

                currentData = new float[chartArray.Series["ArrayValues"].Points.Count];
                for (int i = 0; i < currentData.Length; i++)
                {
                    currentData[i] = (float)chartArray.Series["ArrayValues"].Points[i].YValues[0];
                }


                SyncDataGridViewFromArray(currentData);

            }
            else if (!useChartVisualization && dataGridView1.Visible && dataGridView1.Rows[0].Cells.Count > 0)
            {

                currentData = new float[dataGridView1.ColumnCount];
                for (int i = 0; i < currentData.Length; i++)
                {
                    if (dataGridView1.Rows[0].Cells[i].Value != null &&
                        float.TryParse(dataGridView1.Rows[0].Cells[i].Value.ToString(), out float value))
                    {
                        currentData[i] = value;
                    }
                }


                SyncChartFromArray(currentData);
            }
        }

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            isPaused = false;
            stepMode = false;
            playPictureBox.Visible = false;
            pausePictureBox.Visible = true;
            NextPictureBox.Enabled = false;
        }

        private void pausePictureBox_Click(object sender, EventArgs e)
        {
            ForceSyncBetweenViews();
            isPaused = true;
            playPictureBox.Visible = true;
            pausePictureBox.Visible = false;
            NextPictureBox.Enabled = true;
        }

        private void NextPictureBox_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                stepMode = true;
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (log.Visible == false)
            {
                log.Visible = true;
                legendPanel.Visible = false;
                nightPanel2.Visible = false;
                dataGridView1.Visible = false;
                chartArray.Visible = false;
            }
            else
            {
                log.Visible = false;
                legendPanel.Visible = true;
                if (OptionChoice.option > 6)
                    nightPanel2.Visible = true;
                if (radioGridView.Checked == true)
                {
                    dataGridView1.Visible = true;
                }
                else chartArray.Visible = true;
            }

        }

        private void findbutton_MouseHover(object sender, EventArgs e)
        {

        }

        private void nightPanel2_MouseHover(object sender, EventArgs e)
        {
            if (findbutton.Enabled == false)
            {
                toolTip1.SetToolTip(nightPanel2, "Сначало выполните сортировку массива");
            }
        }
    }
}


