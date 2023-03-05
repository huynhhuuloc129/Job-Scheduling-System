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
	numOfStaff := 1
	numOfShift := 3

	//user
	entry := widget.NewEntry()
	var hboxes []*fyne.Container
	hboxes = append(hboxes, container.NewHBox())
	for i := 1; i <= numOfShift; i++ {
		hboxes[0].Add(widget.NewCheck(fmt.Sprintf("%d", i), nil))
	}
	form := &widget.Form{
		Items: []*widget.FormItem{ // we can specify items in the constructor
			{Text: "Name", Widget: entry},
			{Widget: hboxes[0]},
		},
	}

	//plus user
	btnPlusUser := widget.NewButton("+", func() {
		numOfStaff++
		entryNew := widget.NewEntry()
		hboxes = append(hboxes, container.NewHBox())
		for i := 1; i <= numOfShift; i++ {
			hboxes[numOfStaff-1].Add(widget.NewCheck(fmt.Sprintf("%d", i), nil))
		}

		form.Append("Name", entryNew)
		form.Append("", hboxes[numOfStaff-1])
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
	//plus schedule
	btnPlusShift := widget.NewButton("+", func() {
		numOfShift++
		entryNew := widget.NewEntry()
		formSchedule.Append(fmt.Sprintf("Shift %d", numOfShift), entryNew)
		// Add new checkbox
		for i := range hboxes {
			hboxes[i].Add(widget.NewCheck(fmt.Sprintf("%d", numOfShift), nil))
		}
		addShift(table, len(dayInWeek), numOfShift)
	})

	w.SetContent(container.New(layout.NewGridLayout(2), container.NewVBox(form, btnPlusUser, formSchedule, btnPlusShift), table))
	w.ShowAndRun()
}

func addShift(table *fyne.Container, numColumn int, numOfShift int) {
	table.Add(canvas.NewText(fmt.Sprintf("Shift %d", numOfShift), color.White))
	for i := 0; i < numColumn; i++ {
		table.Add(canvas.NewText("", color.White))
	}
}
