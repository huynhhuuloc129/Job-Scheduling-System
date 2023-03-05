package main

import (
	"fmt"
	"image/color"

	"fyne.io/fyne/v2"
	"fyne.io/fyne/v2/app"
	"fyne.io/fyne/v2/canvas"
	"fyne.io/fyne/v2/container"
	"fyne.io/fyne/v2/layout"
	"fyne.io/fyne/v2/theme"
	"fyne.io/fyne/v2/widget"
)

func main1() {
	x := 0
	app := app.New()
	w := app.NewWindow("Job Scheduling")
	w.Resize(fyne.NewSize(400, 400))
	fyne.CurrentApp().Settings().SetTheme(theme.DarkTheme())

	rect1 := canvas.NewCircle(color.NRGBA{R: 255, G: 255, B: 255, A: 255})
	rect1.Resize(fyne.NewSize(50, 50))
	rect2 := canvas.NewCircle(color.NRGBA{R: 255, G: 255, B: 255, A: 255})
	rect2.Resize(fyne.NewSize(50, 50))
	rect3 := canvas.NewCircle(color.NRGBA{R: 255, G: 255, B: 255, A: 255})
	rect3.Resize(fyne.NewSize(50, 50))

	btnR := widget.NewButton("Red", func() {
		fmt.Printf("%t", true)
		Reset(rect1, rect2, rect3)
		rect1.FillColor = color.NRGBA{R: uint8(incrementMove(x)), G: 0, B: 0, A: 255}
		rect1.Refresh()
	})
	btnG := widget.NewButton("Green", func() {
		Reset(rect1, rect2, rect3)
		rect2.FillColor = color.NRGBA{R: 0, G: uint8(incrementMove(x)), B: 0, A: 255}
		rect2.Refresh()
	})
	btnB := widget.NewButton("Blue", func() {
		Reset(rect1, rect2, rect3)
		rect3.FillColor = color.NRGBA{R: 0, G: 0, B: uint8(incrementMove(x)), A: 255}
		rect3.Refresh()
	})
	btnReset := widget.NewButton("Reset", func() {
		Reset(rect1, rect2, rect3)
	})
	w.SetContent(
		container.NewHSplit(
			container.NewGridWithRows(
				5,
				layout.NewSpacer(),
				rect1,
				rect2,
				rect3,
			),
			container.NewGridWithRows(
				5,
				layout.NewSpacer(),
				btnR,
				btnG,
				btnB,
				btnReset,
			),
		),
	)
	w.ShowAndRun()
}

func incrementMove(x int) (a int) {
	if x == 255 {
		x = 0
	} else {
		x = 255
	}
	return x
}

func Reset(rect1, rect2, rect3 *canvas.Circle) {
	rect1.FillColor = color.RGBA{R: 255, G: 255, B: 255, A: 255}
	rect2.FillColor = color.RGBA{R: 255, G: 255, B: 255, A: 255}
	rect3.FillColor = color.RGBA{R: 255, G: 255, B: 255, A: 255}
	rect1.Refresh()
	rect2.Refresh()
	rect3.Refresh()
}
