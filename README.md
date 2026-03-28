
# 個人房貸試算器

## 專案簡介

本專案為 Visual C# 桌面應用程式，提供個人房貸試算功能，支援自備款比例或金額輸入、寬限期設定，以及房貸關鍵數據計算與顯示。

此系統可讓使用者輸入房屋總價、年利率、貸款年限與寬限期等資訊，計算每月應繳金額、總利息與總還款金額。輸入欄位提供單位提示與預設值，輸出結果採千分位與小數點後兩位格式。


## 作業需求

### 1. 輸入資訊

| 項目             | 型別/模式         | 單位         | 預設值     | 備註                     |
|------------------|-------------------|--------------|------------|--------------------------|
| 房屋總價         | 整數或浮點數      | 新台幣 (NT$) | 0          |                          |
| 自備款           | 百分比 / 金額     | % / NT$      | 20%        | 支援兩種模式，預設百分比 |
| 貸款利率         | 年利率 (%)        | %            | 2%         |                          |
| 貸款年限         | 整數              | 年           | 30         |                          |
| 寬限期 (選填)    | 下拉選單          | 月           | 無         | 12/24/36/48/60 個月可選 |

### 2. 輸出計算後顯示資訊

以下數值顯示格式統一為：千分位逗號 + 小數點後兩位。

- 貸款總金額
- 每月應繳金額 (本 + 息)
- 首期利息與首期本金
- 總利息支出
- 總還款金額

## 計算邏輯說明

### 基本變數

- 房屋總價：$P$
- 自備款金額：$D$
- 貸款本金：$L = P - D$
- 年利率：$r_{annual}$
- 月利率：$r = \frac{r_{annual}}{12}$
- 總期數 (月)：$n = \text{貸款年限} \times 12$
- 寬限期月數：$g$

### 本息平均攤還

若無寬限期，月付金公式：

$$
M = L \cdot \frac{r(1+r)^n}{(1+r)^n-1}
$$

### 含寬限期

- 寬限期內每月僅繳利息：$L \cdot r$
- 寬限期後剩餘期數：$n-g$
- 寬限期後的月付金以前述本息平均攤還公式計算，期數改為 $n-g$

### 首期本金與利息

- 首期利息：$I_1 = L \cdot r$
- 首期本金：$P_1 = M - I_1$

### 總利息與總還款

- 總還款金額：所有期數付款總和
- 總利息支出：總還款金額 $-$ 貸款本金

## 輸入與輸出格式化及防呆機制

### 輸入欄位格式化與防呆

- 所有數值輸入欄位（如金額、利率、年限）皆採用動態格式化機制，使用者輸入時即時顯示千分位、百分比等格式。
- 自備款欄位可切換「百分比」與「金額」模式，切換時自動轉換。
- 欄位輸入時即時檢查數值範圍，不符規則時即時提示錯誤。
- 禁止非數字或不合法字元輸入，並於欄位下方顯示提示訊息。
- 所有輸入欄位皆有單位提示（如 NT$、%、年）。

### 輸出格式化規則

- 所有金額輸出格式：千分位，兩位小數。
- 百分比輸出格式：百分比(%)、兩位小數。

## 開發環境

- 語言：Visual C#
- IDE：Visual Studio 2026
- 作業系統：Windows
- 專案型態：Windows Forms Application

## 專案結構 (示意)

```text
calcloan/
├─ calcloan/
│  ├─ Properties/
│  │  ├─ AssemblyInfo.cs
│  │  ├─ Resources.Designer.cs
│  │  ├─ Resources.resx
│  │  ├─ Settings.Designer.cs
│  │  └─ Settings.settings
│  ├─ Resources/
│  │  ├─ CurrentInstructionPointer_16x.png
│  │  ├─ OverlayRunning.png
│  │  ├─ ScrollbarArrowCollapsed.png
│  │  ├─ ScrollbarArrowCollapsed.svg
│  │  ├─ StatusAlert.12.12.png
│  │  ├─ StatusAlert.13.13.png
│  │  ├─ StatusInvalid.10.10.png
│  │  ├─ StatusInvalid.13.13.png
│  │  ├─ StatusInvalid.15.15.png
│  │  └─ StatusInvalid.18.18.png
│  │  
│  ├─ App.config
│  ├─ Program.cs
│  ├─ calcloan.csproj
│  ├─ frmCalcLoan.Designer.cs
│  ├─ frmCalcLoan.cs
│  └─ frmCalcLoan.resx
│
├─ .gitattributes
├─ .gitignore
├─ LICENSE.txt
├─ README.md
└─ calcloan.slnx

```

## 執行說明

### 1. 操作步驟

- 輸入房屋總價。
- 選擇自備款輸入模式 (百分比 / 金額)。
- 輸入年利率與貸款年限。
- 選擇寬限期。
- 按下試算按鈕，查看輸出結果。

### 2. 測試資料與結果

- 範例輸入：
  - 房屋總價：12,000,000
  - 自備款：20%
  - 年利率：2.15%
  - 貸款年限：30 年
  - 寬限期：無

- 範例輸出（示意）：

```text
貸款總金額: 9,600,000.00
每月應繳金額(本+息): 36,179.34
首期利息: 17,200.00
首期本金: 18,979.34
總利息支出: 3,424,562.40
總還款金額: 13,024,562.40
```

### 3. 關閉應用程式

![關閉應用程式](https://github.com/tim9910/tim9910.github.io/blob/main/images/calcloan/closeapp.png)

## 執行截圖 (範例版面)

### 介面截圖

![UI Screenshot](./images/ui-screenshot.png)

說明範例：主畫面包含房屋總價、自備款模式切換、年利率、貸款年限、寬限期與試算按鈕。

### 試算結果截圖

![Result Screenshot](./images/result-screenshot.png)

說明範例：按下試算後顯示貸款總額、月付金、首期本金利息、總利息與總還款。

### 邊界測試截圖 

![Validation Screenshot](./images/validation-screenshot.png)

說明範例：輸入非法字元或超出範圍時，畫面顯示驗證提示訊息。


