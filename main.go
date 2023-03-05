package main

import (
	"fmt"
	"image/color"

	"fyne.io/fyne/v2"
	"fyne.io/fyne/v2/app"
	"fyne.io/fyne/v2/canvas"
	"fyne.io/fyne/v2/container"
	"fyne.io/fyne/v2/layout"
	"fyne.io/fyne/v2/widget"
)

func main() {
	app := app.New()
	w := app.NewWindow("Job Scheduling")
	// numOfStaff := 1
	numOfShift := 3

	//user
	entry := widget.NewEntry()
	checkbox1 := widget.NewCheck("1", nil)
	checkbox2 := widget.NewCheck("2", nil)
	checkbox3 := widget.NewCheck("3", nil)
	hbox := container.NewHBox(checkbox1, checkbox2, checkbox3)
	form := &widget.Form{
		Items: []*widget.FormItem{ // we can specify items in the constructor
			{Text: "Name", Widget: entry},
			{Text: "", Widget: hbox}},
	}

	//plus user
	btnPlusUser := widget.NewButton("+", func() {
		entryNew := widget.NewEntry()
		checkbox1New := widget.NewCheck("1", nil)
		checkbox2New := widget.NewCheck("2", nil)
		checkbox3New := widget.NewCheck("3", nil)
		hbox := container.NewHBox(checkbox1New, checkbox2New, checkbox3New)
		form.Append("Name", entryNew)
		form.Append("", hbox)
	})

	//schedule
	dayInWeek := []string{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
	var dayFyneObject []fyne.CanvasObject
	dayFyneObject = append(dayFyneObject, canvas.NewText("", color.White))
	for _, day := range dayInWeek {
		dayFyneObject = append(dayFyneObject, canvas.NewText(day, color.White))
	}
	table := container.New(layout.NewGridLayout(8), dayFyneObject...)
	addShift(table, len(dayInWeek), 1)
	addShift(table, len(dayInWeek), 2)
	addShift(table, len(dayInWeek), 3)

	shift1 := widget.NewEntry()
	shift2 := widget.NewEntry()
	shift3 := widget.NewEntry()
	formSchedule := &widget.Form{
		Items: []*widget.FormItem{ // we can specify items in the constructor
			{Text: "Shift 1", Widget: shift1},
			{Text: "Shift 2", Widget: shift2},
			{Text: "Shift 3", Widget: shift3}},
		OnSubmit: func() { // optional, handle form submission
			fmt.Println("Form submitted:", entry.Text)
			fmt.Println("Shift 1:", shift1.Text)
			fmt.Println("Shift 2:", shift2.Text)
			fmt.Println("Shift 3:", shift3.Text)
		},
	}
	btnPlusShift := widget.NewButton("+", func() {
		numOfShift++
		entryNew := widget.NewEntry()
		formSchedule.Append(fmt.Sprintf("Shift %d", numOfShift), entryNew)
		addShift(table, len(dayInWeek), numOfShift)
	})

	w.SetContent(container.New(layout.NewGridLayout(2), container.NewVBox(form, btnPlusUser, formSchedule, btnPlusShift), container.NewVBox(table)))
	w.ShowAndRun()
}

func addShift(table *fyne.Container, numColumn int, numOfShift int) {
	table.Add(canvas.NewText(fmt.Sprintf("Shift %d", numOfShift), color.White))
	for i := 0; i < numColumn; i++ {
		table.Add(canvas.NewText("", color.White))
	}
}
